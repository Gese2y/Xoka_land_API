namespace XOKA.Domain.Entities.TVET
{
    public class Approved_For_Training
	{
		public System.Guid ID { get; set; }
		public string Vital_ID { get; set; }
		public bool? Approved_for_Training { get; set; }
		public System.DateTime? Date_Applyed { get; set; }
		public System.DateTime? End_Date { get; set; }
		public System.Guid? Approved_By { get; set; }


	}
}
