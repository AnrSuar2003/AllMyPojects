public static class IsotopeMapper
{
    public static IsotopePost ToPostgresModel(Isotope iso)
    {
        return new IsotopePost
        {
            Id = iso.Id,
            Name = iso.Name,
            ShowCalibrator = iso.ShowCalibrator,
            ShowProduction = iso.ShowProduction,
            HalfLife = iso.HalfLife,
            DriverId = iso.DriverId,
            AtomicWeight = iso.AtomicWeight,
            IsDefault = iso.IsDefault,
            IsMetaStable = iso.IsMetaStable,
            SyncDate = DateTime.UtcNow
        };
    }
}
