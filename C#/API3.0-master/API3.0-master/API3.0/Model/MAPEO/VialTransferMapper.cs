using API3._0.Model.SQL_SERVER;
using API3._0.Model.POSTGRESQL;

public static class VialTransferMapper
{
    private static DateTime? ToUtc(DateTime? dt)
    {
        return dt.HasValue
            ? DateTime.SpecifyKind(dt.Value, DateTimeKind.Utc)
            : null;
    }

    public static VialTransferPost ToPostgresModel(VialTransfer sql)
    {
        return new VialTransferPost
        {
            Id = sql.Id,
            VialTypeId = sql.VialTypeId,
            CycleId = sql.CycleId,
            AttDeclared = sql.AttDeclared,
            TimeDeclared = ToUtc(sql.TimeDeclared),
            DataDeclared = sql.DataDeclared,
            RadBatch = sql.RadBatch,
            VolumeDeclared = sql.VolumeDeclared,
            PulsesTransferMeasured = sql.PulsesTransferMeasured,
            TotalPulsesCounter = sql.TotalPulsesCounter,
            CounterA = sql.CounterA,
            StepA = sql.StepA,
            CounterB = sql.CounterB,
            StepB = sql.StepB,
            CounterC = sql.CounterC,
            StepC = sql.StepC,
            BottomPosition = sql.BottomPosition,
            IsPigMounted = sql.IsPigMounted,
            IsLoaded = sql.IsLoaded,
            ExpiryTime = ToUtc(sql.ExpiryTime),
            LoadingTime = ToUtc(sql.LoadingTime),
            SyncDate = DateTime.UtcNow
        };
    }
}
