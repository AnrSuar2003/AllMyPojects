public class Radiopharmaceutical
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int? IsotopeId { get; set; }
    public bool Enabled { get; set; }
    public DateTime? TFSinTeo { get; set; }
    public double? ConcCal { get; set; }
    public int? TCalDaysOffset { get; set; }
    public int? ExpiryHours { get; set; }
    public int? ExpiryRef { get; set; }
    public string? TimeZone { get; set; }
    public string? Suffix { get; set; }
    public double? Density { get; set; }
    public string? BatchIdSuffix { get; set; }
    public DateTime? TimeCal { get; set; }
    public bool? IsDefault { get; set; }
    public string? BatchIdPrefix { get; set; }
    public string? BatchIdFormat { get; set; }
    public double? SynthDensity { get; set; }
    public double? DiluterDensity { get; set; }
    public int? FilterTypeId { get; set; }
}
