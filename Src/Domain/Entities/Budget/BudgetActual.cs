namespace XOKA.Domain.Entities.Budget
{
    public class Budget_Actual
    {
        public long Budget_ActualID { get; set; }
        public long? Budget_DetailID { get; set; }
        public string Account_ID { get; set; }
        public double? Actual_Cost { get; set; }
    }
}
