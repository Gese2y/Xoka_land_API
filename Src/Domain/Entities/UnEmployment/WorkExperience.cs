namespace XOKA.Domain.Entities.UnEmployment
{
    public class WorkExperience
	{
		public System.Guid ID { get; set; }
		public string EMP_TIN { get; set; }
		public string Experience { get; set; }
		public double? NO_OF_years { get; set; }
		public System.Guid? Doc_ID { get; set; }
		public System.Guid? Created_By { get; set; }
		public System.Guid? Updated_By { get; set; }
		public byte[] Date_log { get; set; }
		public string Job_Position_ID { get; set; }
	}
}
