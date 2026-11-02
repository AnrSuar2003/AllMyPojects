public static class RadiopharmaceuticalMapper
{
    private static DateTime? ToUtc(DateTime? dt)
    {
        return dt.HasValue
            ? DateTime.SpecifyKind(dt.Value, DateTimeKind.Utc)
            : null;
    }

    public static RadiopharmaceuticalPost ToPostgresModel(Radiopharmaceutical sql)
    {
        return new RadiopharmaceuticalPost
        {
            Id = sql.Id,
            Name = sql.Name,
            IsotopeId = sql.IsotopeId,
            Enabled = sql.Enabled,
            TFSinTeo = ToUtc(sql.TFSinTeo),
            ConcCal = sql.ConcCal,
            TCalDaysOffset = sql.TCalDaysOffset,
            ExpiryHours = sql.ExpiryHours,
            ExpiryRef = sql.ExpiryRef,
            TimeZone = sql.TimeZone,
            Suffix = sql.Suffix,
            Density = sql.Density,
            BatchIdSuffix = sql.BatchIdSuffix,
            TimeCal = ToUtc(sql.TimeCal),
            IsDefault = sql.IsDefault,
            BatchIdPrefix = sql.BatchIdPrefix,
            BatchIdFormat = sql.BatchIdFormat,
            SynthDensity = sql.SynthDensity,
            DiluterDensity = sql.DiluterDensity,
            FilterTypeId = sql.FilterTypeId,
            SyncDate = DateTime.UtcNow
        };
    }
}
