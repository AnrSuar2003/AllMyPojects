using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Isotopes", Schema = "medicina_nuclear")]
public class IsotopePost
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

    public DateTime SyncDate { get; set; }
}
