using API3._0.Model.POSTGRESQL;
using API3._0.Model.SQL_SERVER;

namespace API3._0.Model.MAPEO
{
    public static class LinearityTestMapper
    {
        public static LinearityTestPost ToPostgresModel(LinearityTest sqlEntity)
        {
            return new LinearityTestPost
            {
                Id = sqlEntity.Id,
                IsotopeId = sqlEntity.IsotopeId,
                CalibratorTypeId = sqlEntity.CalibratorTypeId,
                Completed = sqlEntity.Completed,
                Length = sqlEntity.Length,
                Delta = sqlEntity.Delta,
                Date = sqlEntity.Date.HasValue
                    ? DateTime.SpecifyKind(sqlEntity.Date.Value, DateTimeKind.Utc)
                    : (DateTime?)null,
                SyncDate = DateTime.UtcNow
            };
        }
    }
}
