namespace API3._0.Model.POSTGRESQL
{
    public class VialDilutionPost
    {
        public int Id { get; set; }
        public int? CycleId { get; set; }
        public int? VialTransferId { get; set; }
        public double? VolumeRequested { get; set; }
        public int? PulsesTransferMeasured { get; set; }
        public int? PulsesSalineMeasured { get; set; }
        public DateTime SyncDate { get; set; }
    }
}
