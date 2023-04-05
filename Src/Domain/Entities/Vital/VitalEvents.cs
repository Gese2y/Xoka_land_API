namespace XOKA.Domain.Entities.Vital
{
    public class VitalEvents
	{
		public string ID { get; set; }
		public System.DateTime? Date_of_Birth { get; set; }
		public string Blood_Group { get; set; }
		public string Gender { get; set; }
		public string Status { get; set; }
		public System.Guid? Regstered_Org { get; set; }
		public System.Guid? User_ID { get; set; }
		public System.DateTime? created_date { get; set; }
		public System.DateTime? Updated_date { get; set; }
		public System.Guid? Updated_By_user { get; set; }
		public System.Guid? Licence_ID { get; set; }
	}
}
