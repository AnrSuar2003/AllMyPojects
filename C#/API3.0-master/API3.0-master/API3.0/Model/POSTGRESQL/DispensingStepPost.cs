namespace API3._0.Model.POSTGRESQL
{
    public class DispensingStepPost
    {
        public int Id { get; set; }
        public int SyringeId { get; set; }
        public int? CycleId { get; set; }
        public double? Activity { get; set; }
        public DateTime? Time { get; set; }
        public bool? Microbolus { get; set; }
        public bool? Rinsing { get; set; }
        public int? PulsesRadDispensed { get; set; }
        public int? PulsesRadRequested { get; set; }
        public int? PulsesSalineDispensed { get; set; }
        public int? PulsesSalineRequested { get; set; }
        public int? PulsesAirInRad { get; set; }
        public int? PulsesAirInSaline { get; set; }
        public bool? VmEmpty { get; set; }
        public bool? SalineEmpty { get; set; }

        public DateTime SyncDate { get; set; }
    }
}
