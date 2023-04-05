namespace XOKA.Domain.Entities.OCAC
{
    public class ExamResultCertificat
	{
		public System.Guid ID { get; set; }
		public System.Guid? Exam_Result_Id { get; set; }
		public string TEVET_Program_ID { get; set; }
		public System.DateTime? Date_Issued { get; set; }
		public System.DateTime? Expired_Date { get; set; }
		public bool? Is_Summitted_To_candidate { get; set; }
	}
}
