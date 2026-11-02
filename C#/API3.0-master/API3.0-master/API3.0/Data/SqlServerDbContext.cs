using API3._0.Model.SQL_SERVER;
using Microsoft.EntityFrameworkCore;

namespace API3._0.Data
{
    public class SqlServerDbContext:DbContext
    {
        public SqlServerDbContext(DbContextOptions<SqlServerDbContext> options) : base(options) { }

        public DbSet<Syringe> Syringes { get; set; }
        public DbSet<Cycle> Cycles { get; set; }
        public DbSet<VialTransfer> VialTransfers { get; set; }
        public DbSet<VialDilution> VialDilutions { get; set; }
        public DbSet<VialType> VialTypes { get; set; }
        public DbSet<DisposableKit> DisposableKits { get; set; }
        public DbSet<DispensingStep> DispensingSteps { get; set; }

        public DbSet<Radiopharmaceutical> Radiopharmaceuticals { get; set; }

        public DbSet<EnviroRecHeader> EnviroRecHeaders { get; set; }

        public DbSet<Isotope> Isotopes { get; set; }

        public DbSet<LinearityTest> LinearityTests { get; set; }

        public DbSet<LinearityTestDetail> LinearityTestDetails { get; set; }

        public DbSet<IsotopeFactor> IsotopeFactors { get; set; }

        public DbSet<CalibratorType> CalibratorTypes { get; set; }


    }
}
