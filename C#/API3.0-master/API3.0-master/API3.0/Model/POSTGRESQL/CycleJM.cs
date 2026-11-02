namespace API3._0.Model.PostgreSQL
{
    public class CycleJM
    {

        public int Id { get; set; }
        public string? BatchId { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public DateTime? ClosingDate { get; set; }
        public int? ManualPulsesDispensed { get; set; }
        public string? Operator { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? RadiopharmaceuticalId { get; set; }
        public string? SalineBatch { get; set; }
        public DateTime? SalineExpiryDate { get; set; }
        public string? State { get; set; }
        public bool? SystemInitialized { get; set; }
        public bool? PipesFull { get; set; }
        public double? AttWaste { get; set; }
        public DateTime? TimeWaste { get; set; }
        public string? SyringesBatch { get; set; }
        public DateTime? SyringesExpiryDate { get; set; }
        public string? DefluxBatch { get; set; }
        public DateTime? DefluxExpiryDate { get; set; }
        public int? CnnConnectorId { get; set; }
        public DateTime SyncDate { get; set; }

        public DateTime? ModifyDate { get; set; }

    }
}
