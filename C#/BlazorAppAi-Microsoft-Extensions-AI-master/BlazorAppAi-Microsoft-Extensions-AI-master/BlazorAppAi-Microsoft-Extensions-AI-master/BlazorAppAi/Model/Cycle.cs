using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAppAi.Model
{
    [Table("dsa_mn_cycles", Schema = "staging_area")]
    public class Cycle
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Column("BatchId")]
        public string? BatchId { get; set; }

        [Column("ExpiryDate")]
        public DateTime? ExpiryDate { get; set; }

        [Column("ClosingDate")]
        public DateTime? ClosingDate { get; set; }

        [Column("ManualPulsesDispensed")]
        public int? ManualPulsesDispensed { get; set; }

        [Column("Operator")]
        public string? Operator { get; set; }

        [Column("CreationDate")]
        public DateTime? CreationDate { get; set; }

        [Column("RadiopharmaceuticalId")]
        public int? RadiopharmaceuticalId { get; set; }

        [Column("SalineBatch")]
        public string? SalineBatch { get; set; }

        [Column("SalineExpiryDate")]
        public DateTime? SalineExpiryDate { get; set; }

        [Column("State")]
        public string? State { get; set; }

        [Column("SystemInitialized")]
        public bool? SystemInitialized { get; set; }

        [Column("PipesFull")]
        public bool? PipesFull { get; set; }

        [Column("AttWaste")]
        public double? AttWaste { get; set; }

        [Column("TimeWaste")]
        public DateTime? TimeWaste { get; set; }

        [Column("SyringesBatch")]
        public string? SyringesBatch { get; set; }

        [Column("SyringesExpiryDate")]
        public DateTime? SyringesExpiryDate { get; set; }

        [Column("DefluxBatch")]
        public string? DefluxBatch { get; set; }

        [Column("DefluxExpiryDate")]
        public DateTime? DefluxExpiryDate { get; set; }

        [Column("CnnConnectorId")]
        public int? CnnConnectorId { get; set; }

        [Column("SyncDate")]
        public DateTime SyncDate { get; set; }
    }
}
