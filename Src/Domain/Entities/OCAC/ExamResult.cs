namespace XOKA.Domain.Entities.OCAC
{
    public class ExamResult
	{
		public System.Guid ID { get; set; }
		public System.Guid? OCAC_Exam_Cad_ID { get; set; }
		public double? Result_In_Number { get; set; }
		public string Result_In_Text { get; set; }
		public System.DateTime? Date_of_Exam { get; set; }
	}
}
