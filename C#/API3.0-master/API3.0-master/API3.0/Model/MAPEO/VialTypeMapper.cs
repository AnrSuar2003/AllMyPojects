using API3._0.Model.SQL_SERVER;
using API3._0.Model.POSTGRESQL;
using System;

public static class VialTypeMapper
{
    public static VialTypePost ToPostgresModel(VialType sql)
    {
        return new VialTypePost
        {
            Id = sql.Id,
            Description = sql.Description,
            Manufacturer = sql.Manufacturer,
            VialCapacity = sql.VialCapacity,
            ImageName = sql.ImageName,
            QueueFolder = sql.QueueFolder,
            IsDefault = sql.IsDefault,
            TotalActivityMin = sql.TotalActivityMin,
            TotalActivityMax = sql.TotalActivityMax,
            ConcentrationMin = sql.ConcentrationMin,
            ConcentrationMax = sql.ConcentrationMax,
            PulsesPerDilutionStep = sql.PulsesPerDilutionStep,
            PulsesPerLoadingStep = sql.PulsesPerLoadingStep,
            PulsesOfAirDuringLoading = sql.PulsesOfAirDuringLoading,
            QuoteMinFindBottom = sql.QuoteMinFindBottom,
            QuoteMaxFindBottom = sql.QuoteMaxFindBottom,
            IsEnabled = sql.IsEnabled,
            SyncDate = DateTime.UtcNow
        };
    }
}
