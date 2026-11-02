using API3._0.Model.POSTGRESQL;
using API3._0.Model.SQL_SERVER;

namespace API3._0.Model.MAPEO
{
    public static class LinearityTestDetailMapper
    {
        public static LinearityTestDetailPost ToPostgresModel(LinearityTestDetail sqlEntity)
        {
            return new LinearityTestDetailPost
            {
                Id = sqlEntity.Id,
                LinearityTestId = sqlEntity.LinearityTestId,
                ActivityExpected = sqlEntity.ActivityExpected,
                ActivityRead = sqlEntity.ActivityRead,
                TimeRead = sqlEntity.TimeRead.HasValue
                    ? DateTime.SpecifyKind(sqlEntity.TimeRead.Value, DateTimeKind.Utc)
                    : (DateTime?)null,
                SyncDate = DateTime.UtcNow
            };
        }
    }

}
