using System;
using System.Linq;
using System.Threading.Tasks;
using API3._0.Data;
using API3._0.Model.Comparisons;
using API3._0.Model.POSTGRESQL;
using API3._0.Model.SQL_SERVER;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API3._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SincronizacionController : ControllerBase
    {
        private readonly SqlServerDbContext _sqlContext;
        private readonly SyringesPostgresDbContext _pgContext;

        public SincronizacionController(SqlServerDbContext sqlContext, SyringesPostgresDbContext pgContext)
        {
            _sqlContext = sqlContext;
            _pgContext = pgContext;
        }

        [HttpPost("sync")]
        public async Task<IActionResult> SynchronizeData()
        {
            var sqlServerData = await _sqlContext.Syringes.ToListAsync();

            foreach (var source in sqlServerData)
            {
                var target = await _pgContext.Syringes
                    .FirstOrDefaultAsync(r => r.Id == source.Id);

                if (target == null)
                {
                    // Si no existe el registro en PostgreSQL, se agrega un nuevo registro
                    var newTarget = new SyringePost();
                    SyringeComparison.UpdatePostgresEntity(source, newTarget);
                    newTarget.Id = source.Id;

                    // Aseguramos que las fechas estén en UTC
                    SyringeComparison.EnsureDateTimesAreUtc(newTarget);

                    // Establecer SyncDate solo en nuevos registros
                    newTarget.SyncDate = DateTime.UtcNow;

                    await _pgContext.Syringes.AddAsync(newTarget);
                }
                else
                {
                    // Si el registro ya existe, verificamos si ha sido modificado
                    if (!SyringeComparison.CompareObjects(source, target))
                    {
                        // Si se ha modificado, actualizamos el registro
                        SyringeComparison.UpdatePostgresEntity(source, target);
                        SyringeComparison.EnsureDateTimesAreUtc(target);

                        // No modificamos SyncDate
                        _pgContext.Syringes.Update(target);

                        // Ahora, copiamos el registro modificado a la tabla SyringesJM
                        var syringeJM = new SyringeJM();
                        SyringeComparison.CopyToSyringeJM(target, syringeJM);

                        // Asignamos la fecha de modificación en SyringesJM
                        syringeJM.ModifyDate = DateTime.UtcNow;

                        // Guardamos en la tabla SyringesJM
                        await _pgContext.Syringe_JM.AddAsync(syringeJM);
                    }
                }
            }

            await _pgContext.SaveChangesAsync();
            return Ok("Sincronización completa.");
        }
    }
}
