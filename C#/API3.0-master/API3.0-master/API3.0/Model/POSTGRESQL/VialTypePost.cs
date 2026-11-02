namespace API3._0.Model.POSTGRESQL
{
    public class VialTypePost
    {

        public int Id { get; set; }
        public string Description { get; set; }
        public string Manufacturer { get; set; }
        public double? VialCapacity { get; set; }
        public string ImageName { get; set; }
        public string QueueFolder { get; set; }
        public bool? IsDefault { get; set; }
        public double? TotalActivityMin { get; set; }
        public double? TotalActivityMax { get; set; }
        public double? ConcentrationMin { get; set; }
        public double? ConcentrationMax { get; set; }
        public int? PulsesPerDilutionStep { get; set; }
        public int? PulsesPerLoadingStep { get; set; }
        public int? PulsesOfAirDuringLoading { get; set; }
        public int? QuoteMinFindBottom { get; set; }
        public int? QuoteMaxFindBottom { get; set; }
        public bool? IsEnabled { get; set; }
        public DateTime SyncDate { get; set; }
    }
}
