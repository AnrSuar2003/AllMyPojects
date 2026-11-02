namespace API3._0.Model.SQL_SERVER
{
    public class DisposableKit
    {
        public int Id { get; set; }
        public int? CycleId { get; set; }
        public double? CalibrationFactor { get; set; }
        public string? BatchId { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public int? PressureRest { get; set; }
    }
}
