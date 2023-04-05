namespace XOKA.Domain.Entities.SaveCredit
{
    public class Loan
	{
		public System.Guid Loan_Id { get; set; }
		public System.Guid? ApplicationCodeCreadit { get; set; }
		public long? Member_Id { get; set; }
		public System.Guid? MF { get; set; }
		public System.Double? Amount { get; set; }
		public System.DateTime? Request_Date { get; set; }
		public bool? Approved { get; set; }
		public System.DateTime? Approved_Date { get; set; }
		public string Manual_Approved_By { get; set; }
		public bool? Submited { get; set; }
		public string Loan_Status { get; set; }
	}
}
