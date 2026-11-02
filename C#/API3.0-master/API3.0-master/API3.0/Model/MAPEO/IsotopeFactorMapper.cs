using API3._0.Model.POSTGRESQL;
using API3._0.Model.SQL_SERVER;

namespace API3._0.Model.MAPEO
{
    public static class IsotopeFactorMapper
    {
        public static IsotopeFactorPost ToPostgresModel(IsotopeFactor sqlEntity)
        {
            return new IsotopeFactorPost
            {
                Id = sqlEntity.Id,
                CalibratorTypeId = sqlEntity.CalibratorTypeId,
                IsotopeId = sqlEntity.IsotopeId,
                Factor = sqlEntity.Factor,
                SyncDate = DateTime.UtcNow
            };
        }
    }
}
