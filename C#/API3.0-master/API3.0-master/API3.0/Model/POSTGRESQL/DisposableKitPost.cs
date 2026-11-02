namespace API3._0.Model.POSTGRESQL
{
    public class DisposableKitPost
    {
        public int Id { get; set; }
        public int? CycleId { get; set; }
        public double? CalibrationFactor { get; set; }
        public string? BatchId { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public int? PressureRest { get; set; }
        public DateTime? SyncDate { get; set; } // Campo adicional
    }
}
