using API3._0.Model;
using API3._0.Model.POSTGRESQL;
using API3._0.Model.SQL_SERVER;

public static class DisposableKitMapper
{

    private static DateTime? ToUtc(DateTime? dt)
    {
        return dt.HasValue
            ? DateTime.SpecifyKind(dt.Value, DateTimeKind.Utc)
            : null;
    }
    public static DisposableKitPost ToPostgresModel(DisposableKit sql)
    {
        return new DisposableKitPost
        {
            Id = sql.Id,
            CycleId = sql.CycleId,
            CalibrationFactor = sql.CalibrationFactor,
            BatchId = sql.BatchId,
            ExpiryDate = ToUtc(sql.ExpiryDate),
            PressureRest = sql.PressureRest,
            SyncDate = DateTime.UtcNow 
        };
    }
}
