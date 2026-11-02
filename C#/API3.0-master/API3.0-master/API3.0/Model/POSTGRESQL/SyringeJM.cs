using System;

namespace API3._0.Model.POSTGRESQL
{
    public class SyringeJM
    {
        public int Id { get; set; }  // Este campo puede existir, pero no es clave primaria

        public int CycleId { get; set; }
        public float? AttReq { get; set; }
        public float? VolReq { get; set; }
        public DateTime? TimeReq { get; set; }
        public bool? IsAdjusted { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Gender { get; set; }
        public float? Height { get; set; }
        public float? Weight { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public string State { get; set; }
        public string UniqueId { get; set; }
        public float? AttDispensed { get; set; }
        public DateTime? TimeDispensed { get; set; }
        public float? AttMc { get; set; }
        public DateTime? TimeMc { get; set; }
        public int? PulsesVolumeDispensedSb2 { get; set; }
        public int? PulsesAirDispensedSb2 { get; set; }
        public int? DispensingOrder { get; set; }
        public float? Background { get; set; }
        public DateTime? TimeBackground { get; set; }
        public bool? DirectInfusion { get; set; }
        public float? AttReqOriginal { get; set; }
        public DateTime? TimeReqOriginal { get; set; }
        public bool? IsOverDosed { get; set; }
        public bool? IsUnderDosed { get; set; }
        public int? SyringeOrder { get; set; }
        public bool? IsVmEmpty { get; set; }
        public string DispensingMode { get; set; }
        public string InjectionMode { get; set; }
        public bool? IsTransferFailed { get; set; }
        public int? EnviroRecHeaderId { get; set; }
        public string DispensedBy { get; set; }
        public bool? UploadError { get; set; }
        public bool? IsInjected { get; set; }
        public DateTime? InjectionTime { get; set; }
        public int? VialTransfer { get; set; }
        public int? Study { get; set; }

        public DateTime? SyncDate { get; set; }

        // Nuevo campo: ModifyDate para registrar la fecha de modificación
        public DateTime? ModifyDate { get; set; }

       
    }
}
