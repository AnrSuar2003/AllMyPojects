using API3._0.Model.POSTGRESQL;
using API3._0.Model.SQL_SERVER;

public static class SyringeMapper
{
    private static DateTime? ToUtc(DateTime? dt)
    {
        return dt.HasValue
            ? DateTime.SpecifyKind(dt.Value, DateTimeKind.Utc)
            : null;
    }

    public static SyringePost ToPostgresModel(Syringe sql)
    {
        return new SyringePost
        {
            Id = sql.Id,
            CycleId = sql.CycleId,
            AttReq = sql.AttReq,
            VolReq = sql.VolReq,
            TimeReq = ToUtc(sql.TimeReq),
            IsAdjusted = sql.IsAdjusted,
            DateOfBirth = ToUtc(sql.DateOfBirth),
            Gender = sql.Gender,
            Height = sql.Height,
            Weight = sql.Weight,
            LastName = sql.LastName,
            Name = sql.Name,
            Notes = sql.Notes,
            State = sql.State,
            UniqueId = sql.UniqueId,
            AttDispensed = sql.AttDispensed,
            TimeDispensed = ToUtc(sql.TimeDispensed),
            AttMc = sql.AttMc,
            TimeMc = ToUtc(sql.TimeMc),
            PulsesVolumeDispensedSb2 = sql.PulsesVolumeDispensedSb2,
            PulsesAirDispensedSb2 = sql.PulsesAirDispensedSb2,
            DispensingOrder = sql.DispensingOrder,
            Background = sql.Background,
            TimeBackground = ToUtc(sql.TimeBackground),
            DirectInfusion = sql.DirectInfusion,
            AttReqOriginal = sql.AttReqOriginal,
            TimeReqOriginal = ToUtc(sql.TimeReqOriginal),
            IsOverDosed = sql.IsOverDosed,
            IsUnderDosed = sql.IsUnderDosed,
            SyringeOrder = sql.SyringeOrder,
            IsVmEmpty = sql.IsVmEmpty,
            DispensingMode = sql.DispensingMode,
            InjectionMode = sql.InjectionMode,
            IsTransferFailed = sql.IsTransferFailed,
            EnviroRecHeaderId = sql.EnviroRecHeaderId,
            DispensedBy = sql.DispensedBy,
            UploadError = sql.UploadError,
            IsInjected = sql.IsInjected,
            InjectionTime = ToUtc(sql.InjectionTime),
            VialTransfer = sql.VialTransfer,
            Study = sql.Study,
            SyncDate = DateTime.UtcNow
        };
    }

   


}
