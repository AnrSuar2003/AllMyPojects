using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

[Table("EnviroRecHeaders", Schema = "medicina_nuclear")]
public class EnviroRecHeaderPost
{
    [Key]
    public int Id { get; set; }

    public string? Description { get; set; }

    public int Channel { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? StopTime { get; set; }

    public int? MeasureUnit { get; set; }

    public DateTime SyncDate { get; set; }
}
