using API3._0.Model.PostgreSQL;
using API3._0.Model.POSTGRESQL;
using API3._0.Model.SQL_SERVER;
using Microsoft.EntityFrameworkCore;

namespace API3._0.Data
{
    public class SyringesPostgresDbContext:DbContext
    {
        public SyringesPostgresDbContext(DbContextOptions<SyringesPostgresDbContext> options)
        : base(options)
        {
        }

        public DbSet<SyringePost> Syringes { get; set; }
        public DbSet<SyringeJM> Syringe_JM { get; set; }

        public DbSet<CyclePost> Cycles { get; set; }
        public DbSet<CycleJM> Cycles_JM { get; set; }

        public DbSet<VialTransferPost> VialTransfers { get; set; }

        public DbSet<VialDilutionPost> VialDilutions { get; set; }

        public DbSet<VialTypePost> VialTypes { get; set; }

        public DbSet<DisposableKitPost> DisposableKits { get; set; }

        public DbSet<DispensingStepPost> DispensingSteps { get; set; }

        public DbSet<RadiopharmaceuticalPost> Radiopharmaceuticals { get; set; }

        public DbSet<EnviroRecHeaderPost> EnviroRecHeaders { get; set; }

        public DbSet<IsotopePost> Isotopes { get; set; }

        public DbSet<LinearityTestPost> LinearityTests { get; set; }


        public DbSet<LinearityTestDetailPost> LinearityTestDetails { get; set; }

        public DbSet<IsotopeFactorPost> IsotopeFactors { get; set; }

        public DbSet<CalibratorTypePost> CalibratorTypes { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<SyringePost>().ToTable("Syringes", schema: "medicina_nuclear");
            modelBuilder.Entity<SyringeJM>().ToTable("Syringe_JM", schema: "medicina_nuclear");
            modelBuilder.Entity<CyclePost>().ToTable("Cycles", schema: "medicina_nuclear");
            modelBuilder.Entity<CycleJM>().ToTable("Cycles_JM", schema: "medicina_nuclear");
            modelBuilder.Entity<VialTransferPost>().ToTable("VialTransfers", schema: "medicina_nuclear");
            modelBuilder.Entity<VialDilutionPost>().ToTable("VialDilutions", schema: "medicina_nuclear");
            modelBuilder.Entity<VialTypePost>().ToTable("VialTypes", schema: "medicina_nuclear");
            modelBuilder.Entity<DisposableKitPost>().ToTable("DisposableKits", schema: "medicina_nuclear");
            modelBuilder.Entity<DispensingStepPost>().ToTable("DispensingSteps", schema: "medicina_nuclear");
            modelBuilder.Entity<RadiopharmaceuticalPost>().ToTable("Radiopharmaceuticals", schema: "medicina_nuclear");
            modelBuilder.Entity<EnviroRecHeaderPost>().ToTable("EnviroRecHeaders", schema: "medicina_nuclear");
            modelBuilder.Entity<IsotopePost>().ToTable("Isotopes", schema: "medicina_nuclear");
            modelBuilder.Entity<LinearityTestPost>().ToTable("LinearityTests", schema: "medicina_nuclear");
            modelBuilder.Entity<LinearityTestDetailPost>().ToTable("LinearityTestDetails", schema: "medicina_nuclear");
            modelBuilder.Entity<IsotopeFactorPost>().ToTable("IsotopeFactors", schema: "medicina_nuclear");
            modelBuilder.Entity<CalibratorTypePost>().ToTable("CalibratorTypes", schema: "medicina_nuclear");


        }
    }
}