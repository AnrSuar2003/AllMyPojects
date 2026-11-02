using API3._0.Model.SQL_SERVER;
using API3._0.Model.POSTGRESQL;

public static class CycleMapper
{
    private static DateTime? ToUtc(DateTime? dt)
    {
        return dt.HasValue
            ? DateTime.SpecifyKind(dt.Value, DateTimeKind.Utc)
            : null;
    }

    public static CyclePost ToPostgresModel(Cycle sql)
    {
        return new CyclePost
        {
            Id = sql.Id,
            BatchId = sql.BatchId,
            ExpiryDate = ToUtc(sql.ExpiryDate),
            ClosingDate = ToUtc(sql.ClosingDate),
            ManualPulsesDispensed = sql.ManualPulsesDispensed,
            Operator = sql.Operator,
            CreationDate = ToUtc(sql.CreationDate),
            RadiopharmaceuticalId = sql.RadiopharmaceuticalId,
            SalineBatch = sql.SalineBatch,
            SalineExpiryDate = ToUtc(sql.SalineExpiryDate),
            State = sql.State,
            SystemInitialized = sql.SystemInitialized,
            PipesFull = sql.PipesFull,
            AttWaste = sql.AttWaste,
            TimeWaste = ToUtc(sql.TimeWaste),
            SyringesBatch = sql.SyringesBatch,
            SyringesExpiryDate = ToUtc(sql.SyringesExpiryDate),
            DefluxBatch = sql.DefluxBatch,
            DefluxExpiryDate = ToUtc(sql.DefluxExpiryDate),
            CnnConnectorId = sql.CnnConnectorId,
            SyncDate = DateTime.UtcNow
        };
    }
}
