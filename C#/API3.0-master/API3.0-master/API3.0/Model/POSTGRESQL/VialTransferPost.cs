using System.ComponentModel.DataAnnotations.Schema;

namespace API3._0.Model.POSTGRESQL
{
    [Table("VialTransfers", Schema = "medicina_nuclear")]
    public class VialTransferPost
    {
        public int Id { get; set; }
        public int? VialTypeId { get; set; }
        public int? CycleId { get; set; }
        public double? AttDeclared { get; set; }
        public DateTime? TimeDeclared { get; set; }
        public bool? DataDeclared { get; set; }
        public string? RadBatch { get; set; }
        public double? VolumeDeclared { get; set; }
        public int? PulsesTransferMeasured { get; set; }
        public int? TotalPulsesCounter { get; set; }
        public int? CounterA { get; set; }
        public int? StepA { get; set; }
        public int? CounterB { get; set; }
        public int? StepB { get; set; }
        public int? CounterC { get; set; }
        public int? StepC { get; set; }
        public int? BottomPosition { get; set; }
        public bool? IsPigMounted { get; set; }
        public bool? IsLoaded { get; set; }
        public DateTime? ExpiryTime { get; set; }
        public DateTime? LoadingTime { get; set; }
        public DateTime? SyncDate { get; set; }
    }
}
