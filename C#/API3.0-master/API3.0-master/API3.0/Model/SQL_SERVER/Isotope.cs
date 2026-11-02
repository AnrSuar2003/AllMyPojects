using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Isotopes")]
public class Isotope
{
    [Key]
    public int Id { get; set; }

    public string? Name { get; set; }

    public bool? ShowCalibrator { get; set; }

    public bool? ShowProduction { get; set; }

    public double? HalfLife { get; set; }

    public int? DriverId { get; set; }

    public int? AtomicWeight { get; set; }

    public bool? IsDefault { get; set; }

    public bool? IsMetaStable { get; set; }
}
