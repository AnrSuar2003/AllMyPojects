namespace API3._0.Model.SQL_SERVER
{
    public class VialDilution
    {
        public int Id { get; set; }
        public int? CycleId { get; set; }
        public int? VialTransferId { get; set; }
        public double? VolumeRequested { get; set; }
        public int? PulsesTransferMeasured { get; set; }
        public int? PulsesSalineMeasured { get; set; }
    }
}
