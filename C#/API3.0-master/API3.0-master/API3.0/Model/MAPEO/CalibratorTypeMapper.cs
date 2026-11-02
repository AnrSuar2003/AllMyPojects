using API3._0.Model.POSTGRESQL;
using API3._0.Model.SQL_SERVER;

namespace API3._0.Model.MAPEO
{
    public static class CalibratorTypeMapper
    {
        public static CalibratorTypePost ToPostgresModel(CalibratorType sqlEntity)
        {
            return new CalibratorTypePost
            {
                Id = sqlEntity.Id,
                Manufacturer = sqlEntity.Manufacturer,
                Model = sqlEntity.Model,
                DrvName = sqlEntity.DrvName,
                StabilizationTime = sqlEntity.StabilizationTime,
                SyncDate = DateTime.UtcNow
            };
        }
    }
}
