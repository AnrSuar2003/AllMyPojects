using BlazorAppAi.Model;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppAi.Data
{
    public class DbContextPost:DbContext
    {

        public DbContextPost(DbContextOptions<DbContextPost> options)
            :base(options)
        {
            
        }
        public DbSet<FactMnPacientesInyectados> FactMnPacientesInyectados { get; set; }
        public DbSet<Cycle> Ciclos { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<FactMnPacientesInyectados>(entity =>
            {
                entity.ToTable("fact_mn_pacientes_inyectados", "dwh_area");

                entity.HasKey(e => new { e.DmCedulaId, e.DmCycleId }); // Clave compuesta
            });


            modelBuilder.Entity<Cycle>(entity =>
            {
                entity.ToTable("dsa_mn_cycles", "staging_area");


            });


        }

    }
}
