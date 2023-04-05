namespace XOKA.Domain.Entities.SaveCredit
{
    public class Repayment
    {
        public System.Guid LoanID { get; set; }
        public System.Guid UserID { get; set; }
        public System.DateTime? RegistrationDate { get; set; }
        public string LoanAmount { get; set; }
        public string Repayments { get; set; }
        public string Balance { get; set; }

    }
}
