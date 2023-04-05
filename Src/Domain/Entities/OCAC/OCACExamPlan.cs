namespace XOKA.Domain.Entities.OCAC
{
    public class OCACExamPlan
	{
		public System.Guid OCAC_Exam_Plan_ID { get; set; }
		public System.Guid? Application_code { get; set; }
		public System.Guid? Orgnization_Code { get; set; }
		public string Centor_Code { get; set; }
		public string OS_Code { get; set; }
		public string Exam_Code { get; set; }
		public System.DateTime? Year { get; set; }
		public System.DateTime? Start_Date { get; set; }
		public System.DateTime? End_Date { get; set; }
		public System.TimeSpan? Start_Hour { get; set; }
		public System.TimeSpan End_Hour { get; set; }
		public string Venue { get; set; }

	}
}
