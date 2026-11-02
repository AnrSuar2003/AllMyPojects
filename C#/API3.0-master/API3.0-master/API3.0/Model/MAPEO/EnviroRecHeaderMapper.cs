using API3._0.Model.SQL_SERVER;
using API3._0.Model.POSTGRESQL;

public static class EnviroRecHeaderMapper
{
    private static DateTime? ToUtc(DateTime? dt)
    {
        return dt.HasValue ? DateTime.SpecifyKind(dt.Value, DateTimeKind.Utc) : null;
    }

    public static EnviroRecHeaderPost ToPostgresModel(EnviroRecHeader sql)
    {
        return new EnviroRecHeaderPost
        {
            Id = sql.Id,
            Description = sql.Description,
            Channel = sql.Channel,
            StartTime = ToUtc(sql.StartTime),
            StopTime = ToUtc(sql.StopTime),
            MeasureUnit = sql.MeasureUnit,
            SyncDate = DateTime.UtcNow
        };
    }
}
