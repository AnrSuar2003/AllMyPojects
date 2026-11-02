using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAppAi.Model
{
    [Table("fact_mn_pacientes_inyectados", Schema = "dwh_area")]
    public class FactMnPacientesInyectados
    {

        [Key, Column("dm_cedula_id")]
        public string DmCedulaId { get; set; }

        [Key, Column("dm_cycle_id")]
        public int DmCycleId { get; set; }

        [Column("dm_fecha_nacimiento")]
        public DateTime? DmFechaNacimiento { get; set; }

        [Column("dm_altura")]
        public double? DmAltura { get; set; }

        [Column("dm_peso")]
        public double? DmPeso { get; set; }

        [Column("dm_sexo_id")]
        public string? DmSexoId { get; set; }

        [Column("dm_hora_preparacion")]
        public string? DmHoraPreparacion { get; set; }

        [Column("dm_tiempo_requerido")]
        public string? DmTiempoRequerido { get; set; }

        [Column("dm_actividad_requerida")]
        public double? DmActividadRequerida { get; set; }

        [Column("dm_actividad_dispensada")]
        public double? DmActividadDispensada { get; set; }

        [Column("dm_actividad_administrada")]
        public double? DmActividadAdministrada { get; set; }

        [Column("dm_desviacion_porcentaje")]
        public string? DmDesviacionPorcentaje { get; set; }
    }
}
