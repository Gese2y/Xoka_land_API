using System;

namespace XOKA.Domain.Entities.OCAC
{
    public class OCACExamCandidate
	{
		public System.Guid OCAC_Candiate { get; set; }
		public System.Guid? OCAC_Exam_Plan_ID { get; set; }
		public System.Guid? Cand_ID { get; set; }
		public byte[]? IS_Approved { get; set; }
		public string IS_Present { get; set; }
		public string Remark { get; set; }
		public string Student { get; set; }
	}
}
