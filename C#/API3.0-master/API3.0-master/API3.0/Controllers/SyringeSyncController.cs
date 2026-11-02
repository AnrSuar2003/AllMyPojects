using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API3._0.Model;
using API3._0.Data;
using API3._0.Model.SQL_SERVER;
using API3._0.Model.POSTGRESQL;
using API3._0.Model.MAPEO;

[ApiController]
[Route("api/[controller]")]
public class SyringeSyncController : ControllerBase
{
    private readonly SqlServerDbContext _sqlContext;
    private readonly SyringesPostgresDbContext _pgContext;

    public SyringeSyncController(SqlServerDbContext sqlContext, SyringesPostgresDbContext pgContext)
    {
        _sqlContext = sqlContext;
        _pgContext = pgContext;
    }

    [HttpPost("sync")]
    public async Task<IActionResult> Sync()
    {
        try
        {
            // Syringes
            var sqlSyringeData = await _sqlContext.Syringes.ToListAsync();
            if (!sqlSyringeData.Any()) return Ok("No hay datos en SQL Server para Syringes.");

            var existingSyringeIds = await _pgContext.Syringes.Select(s => s.Id).ToListAsync();
            var newSyringes = sqlSyringeData
                .Where(s => !existingSyringeIds.Contains(s.Id))
                .Select(SyringeMapper.ToPostgresModel)
                .ToList();

            if (newSyringes.Any())
            {
                await _pgContext.Syringes.AddRangeAsync(newSyringes);
                await _pgContext.SaveChangesAsync();
            }

            // Cycles
            var sqlCycleData = await _sqlContext.Cycles.ToListAsync();
            if (!sqlCycleData.Any()) return Ok("No hay datos en SQL Server para Cycles.");

            var existingCycleIds = await _pgContext.Cycles.Select(c => c.Id).ToListAsync();
            var newCycles = sqlCycleData
                .Where(c => !existingCycleIds.Contains(c.Id))
                .Select(CycleMapper.ToPostgresModel)
                .ToList();

            if (newCycles.Any())
            {
                await _pgContext.Cycles.AddRangeAsync(newCycles);
                await _pgContext.SaveChangesAsync();
            }

            // VialTransfers
            var sqlVialData = await _sqlContext.VialTransfers.ToListAsync();
            if (!sqlVialData.Any()) return Ok("No hay datos en SQL Server para VialTransfers.");

            var existingVialIds = await _pgContext.VialTransfers.Select(v => v.Id).ToListAsync();
            var newVials = sqlVialData
                .Where(v => !existingVialIds.Contains(v.Id))
                .Select(VialTransferMapper.ToPostgresModel)
                .ToList();

            if (newVials.Any())
            {
                await _pgContext.VialTransfers.AddRangeAsync(newVials);
                await _pgContext.SaveChangesAsync();
            }

            // VialDilutions
            var sqlVialDilutionData = await _sqlContext.VialDilutions.ToListAsync();
            if (!sqlVialDilutionData.Any()) return Ok("No hay datos en SQL Server para VialDilutions.");

            var existingVialDilutionIds = await _pgContext.VialDilutions.Select(v => v.Id).ToListAsync();
            var newVialDilutions = sqlVialDilutionData
                .Where(v => !existingVialDilutionIds.Contains(v.Id))
                .Select(VialDilutionMapper.ToPostgresModel)
                .ToList();

            if (newVialDilutions.Any())
            {
                await _pgContext.VialDilutions.AddRangeAsync(newVialDilutions);
                await _pgContext.SaveChangesAsync();
            }

            // VialTypes
            var newVialTypes = new List<VialTypePost>(); // Declaración fuera del if
            var sqlVialTypes = await _sqlContext.VialTypes.ToListAsync();
            if (sqlVialTypes.Any())
            {
                var existingVialTypeIds = await _pgContext.VialTypes.Select(v => v.Id).ToListAsync();
                newVialTypes = sqlVialTypes
                    .Where(v => !existingVialTypeIds.Contains(v.Id))
                    .Select(VialTypeMapper.ToPostgresModel)
                    .ToList();

                if (newVialTypes.Any())
                {
                    await _pgContext.VialTypes.AddRangeAsync(newVialTypes);
                    await _pgContext.SaveChangesAsync();
                }
            }

            // DisposableKits
            var newDisposableKits = new List<DisposableKitPost>(); // Declaración fuera del if
            var sqlDisposableKits = await _sqlContext.DisposableKits.ToListAsync();
            if (sqlDisposableKits.Any())
            {
                var existingDisposableKitIds = await _pgContext.DisposableKits.Select(d => d.Id).ToListAsync();
                newDisposableKits = sqlDisposableKits
                    .Where(d => !existingDisposableKitIds.Contains(d.Id))
                    .Select(DisposableKitMapper.ToPostgresModel)
                    .ToList();

                if (newDisposableKits.Any())
                {
                    await _pgContext.DisposableKits.AddRangeAsync(newDisposableKits);
                    await _pgContext.SaveChangesAsync();
                }
            }

            // DispensingSteps
            var sqlDispensingSteps = await _sqlContext.DispensingSteps.ToListAsync();
            if (!sqlDispensingSteps.Any()) return Ok("No hay datos en SQL Server para DispensingSteps.");

            var existingStepIds = await _pgContext.DispensingSteps.Select(d => d.Id).ToListAsync();
            var newSteps = sqlDispensingSteps
                .Where(d => !existingStepIds.Contains(d.Id))
                .Select(DispensingStepMapper.ToPostgresModel)
                .ToList();

            if (newSteps.Any())
            {
                await _pgContext.DispensingSteps.AddRangeAsync(newSteps);
                await _pgContext.SaveChangesAsync();
            }



            var sqlRadioData = await _sqlContext.Radiopharmaceuticals
     .Where(r => r.Id != 0) // ⚠️ Filtrar registros inválidos
     .ToListAsync();

            if (!sqlRadioData.Any())
                return Ok("No hay datos válidos en SQL Server para Radiopharmaceuticals.");

            var existingRadioIds = await _pgContext.Radiopharmaceuticals
                .Select(r => r.Id)
                .ToListAsync();

            var newRadiopharmaceuticals = sqlRadioData
                .Where(r => !existingRadioIds.Contains(r.Id))
                .Select(RadiopharmaceuticalMapper.ToPostgresModel)
                .ToList();

            if (newRadiopharmaceuticals.Any())
            {
                await _pgContext.Radiopharmaceuticals.AddRangeAsync(newRadiopharmaceuticals);
                await _pgContext.SaveChangesAsync();
            }




            var sqlEnviroRecData = await _sqlContext.EnviroRecHeaders
            .Where(e => e.Id != 0) // ✅ Filtrar registros inválidos de SQL Server
            .ToListAsync();

            if (!sqlEnviroRecData.Any())
                return Ok("No hay datos válidos en SQL Server para EnviroRecHeaders."); // ❗ El mensaje decía Radiopharmaceuticals, lo corregí aquí

            var existingEnviroIds = await _pgContext.EnviroRecHeaders
                .Select(e => e.Id)
                .ToListAsync();

            var newEnviroRecHeaders = sqlEnviroRecData
                .Where(e => !existingEnviroIds.Contains(e.Id))
                .Select(EnviroRecHeaderMapper.ToPostgresModel)
                .ToList();

            if (newEnviroRecHeaders.Any())
            {
                await _pgContext.EnviroRecHeaders.AddRangeAsync(newEnviroRecHeaders);
                await _pgContext.SaveChangesAsync();
            }


            var sqlIsotopeData = await _sqlContext.Isotopes
    .Where(i => i.Id != 0) // ⚠️ Filtrar registros inválidos si aplica
    .ToListAsync();

            if (!sqlIsotopeData.Any())
                return Ok("No hay datos válidos en SQL Server para Isotopes.");

            var existingIsotopeIds = await _pgContext.Isotopes
                .Select(i => i.Id)
                .ToListAsync();

            var newIsotopes = sqlIsotopeData
                .Where(i => !existingIsotopeIds.Contains(i.Id))
                .Select(IsotopeMapper.ToPostgresModel)
                .ToList();

            if (newIsotopes.Any())
            {
                await _pgContext.Isotopes.AddRangeAsync(newIsotopes);
                await _pgContext.SaveChangesAsync();
            }


            var sqlLinearityData = await _sqlContext.LinearityTests
             .Where(l => l.Id != 0) // ⚠️ Filtro por ID válido
             .ToListAsync();

            if (!sqlLinearityData.Any())
                return Ok("No hay datos válidos en SQL Server para LinearityTests.");

            var existingLinearityIds = await _pgContext.LinearityTests
                .Select(l => l.Id)
                .ToListAsync();

            var newLinearityTests = sqlLinearityData
                .Where(l => !existingLinearityIds.Contains(l.Id))
                .Select(LinearityTestMapper.ToPostgresModel)
                .ToList();

            if (newLinearityTests.Any())
            {
                await _pgContext.LinearityTests.AddRangeAsync(newLinearityTests);
                await _pgContext.SaveChangesAsync();
            }


            var sqlLinearityDetailData = await _sqlContext.LinearityTestDetails
              .Where(d => d.Id != 0) // ⚠️ Evitar registros con ID inválido
              .ToListAsync();

            if (!sqlLinearityDetailData.Any())
                return Ok("No hay datos válidos en SQL Server para LinearityTestDetails.");

            var existingDetailIds = await _pgContext.LinearityTestDetails
                .Select(d => d.Id)
                .ToListAsync();

            var newLinearityDetails = sqlLinearityDetailData
                .Where(d => !existingDetailIds.Contains(d.Id))
                .Select(LinearityTestDetailMapper.ToPostgresModel)
                .ToList();

            if (newLinearityDetails.Any())
            {
                await _pgContext.LinearityTestDetails.AddRangeAsync(newLinearityDetails);
                await _pgContext.SaveChangesAsync();
            }



            var sqlIsotopeFactors = await _sqlContext.IsotopeFactors
             .Where(f => f.Id != 0) // ⚠️ Filtrar registros inválidos
             .ToListAsync();

            if (!sqlIsotopeFactors.Any())
                return Ok("No hay datos válidos en SQL Server para IsotopeFactors.");

            var existingIsotopeFactorIds = await _pgContext.IsotopeFactors
                .Select(f => f.Id)
                .ToListAsync();

            var newIsotopeFactors = sqlIsotopeFactors
                .Where(f => !existingIsotopeFactorIds.Contains(f.Id))
                .Select(IsotopeFactorMapper.ToPostgresModel)
                .ToList();

            if (newIsotopeFactors.Any())
            {
                await _pgContext.IsotopeFactors.AddRangeAsync(newIsotopeFactors);
                await _pgContext.SaveChangesAsync();
            }



            var sqlCalibratorTypes = await _sqlContext.CalibratorTypes
             .Where(c => c.Id != 0) // ⚠️ Filtrar registros inválidos
             .ToListAsync();

            if (!sqlCalibratorTypes.Any())
                return Ok("No hay datos válidos en SQL Server para CalibratorTypes.");

            var existingCalibratorTypeIds = await _pgContext.CalibratorTypes
                .Select(c => c.Id)
                .ToListAsync();

            var newCalibratorTypes = sqlCalibratorTypes
                .Where(c => !existingCalibratorTypeIds.Contains(c.Id))
                .Select(CalibratorTypeMapper.ToPostgresModel)
                .ToList();

            if (newCalibratorTypes.Any())
            {
                await _pgContext.CalibratorTypes.AddRangeAsync(newCalibratorTypes);
                await _pgContext.SaveChangesAsync();
            }



            return Ok(new
            {
                message = "Datos sincronizados correctamente.",
                syringesInsertados = newSyringes.Count,
                cyclesInsertados = newCycles.Count,
                vialTransfersInsertados = newVials.Count,
                vialDilutioninsertados = newVialDilutions.Count,
                vialTypeInsertados = newVialTypes.Count,
                disposableKitsInsertados = newDisposableKits.Count,
                dispensingStepsInsertados = newSteps.Count,
                radiopharmaceuticalsInsertados = newRadiopharmaceuticals.Count,
                enviroRecHeaderInsertados = newEnviroRecHeaders.Count,
                isotpesInsertados = newIsotopes.Count,
                LinearityTestInsertados = newLinearityTests.Count,
                LinearityTestDetailInsertados = newLinearityDetails.Count,
                IsotopeFactorsInsertados = newIsotopeFactors.Count,
                CalibratorFactorsInsertados = newCalibratorTypes.Count

            });
        }
        catch (Exception ex)
        {
            string inner = ex.InnerException?.Message ?? ex.Message;
            return StatusCode(500, $"❌ Error en la sincronización: {inner}");
        }
    }
}
