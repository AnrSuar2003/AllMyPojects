using API3._0.Model.SQL_SERVER;
using API3._0.Model.POSTGRESQL;
using System;

namespace API3._0.Model
{
    public static class VialDilutionMapper
    {
        public static VialDilutionPost ToPostgresModel(VialDilution sql)
        {
            return new VialDilutionPost
            {
                Id = sql.Id,
                CycleId = sql.CycleId,
                VialTransferId = sql.VialTransferId,
                VolumeRequested = sql.VolumeRequested,
                PulsesTransferMeasured = sql.PulsesTransferMeasured,
                PulsesSalineMeasured = sql.PulsesSalineMeasured,
                SyncDate = DateTime.UtcNow // Agregamos SyncDate en PostgreSQL
            };
        }
    }
}
