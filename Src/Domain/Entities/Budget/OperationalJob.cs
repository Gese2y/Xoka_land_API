namespace XOKA.Domain.Entities.Budget
{
    public class OperationalJob
    {
        public System.Guid Job_ID { get; set; }
        public System.Guid? JobPA_ID { get; set; }
        public string Operational_Job { get; set; }
        public string Value_In_Percent { get; set; }
        public string Unit { get; set; }
        public double Target { get; set; }
        public string Expected_Result { get; set; }
    }
}
