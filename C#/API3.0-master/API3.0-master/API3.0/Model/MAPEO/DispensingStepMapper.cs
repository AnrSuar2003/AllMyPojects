using API3._0.Model.SQL_SERVER;
using API3._0.Model.POSTGRESQL;

public static class DispensingStepMapper
{
    private static DateTime? ToUtc(DateTime? dt)
    {
        return dt.HasValue
            ? DateTime.SpecifyKind(dt.Value, DateTimeKind.Utc)
            : null;
    }

    public static DispensingStepPost ToPostgresModel(DispensingStep sql)
    {
        return new DispensingStepPost
        {
            Id = sql.Id,
            SyringeId = sql.SyringeId,
            CycleId = sql.CycleId,
            Activity = sql.Activity,
            Time = ToUtc(sql.Time),
            Microbolus = sql.Microbolus,
            Rinsing = sql.Rinsing,
            PulsesRadDispensed = sql.PulsesRadDispensed,
            PulsesRadRequested = sql.PulsesRadRequested,
            PulsesSalineDispensed = sql.PulsesSalineDispensed,
            PulsesSalineRequested = sql.PulsesSalineRequested,
            PulsesAirInRad = sql.PulsesAirInRad,
            PulsesAirInSaline = sql.PulsesAirInSaline,
            VmEmpty = sql.VmEmpty,
            SalineEmpty = sql.SalineEmpty,
            SyncDate = DateTime.UtcNow
        };
    }
}
