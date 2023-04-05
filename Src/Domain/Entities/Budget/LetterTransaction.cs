using System;

namespace XOKA.Domain.Entities.Budget
{
    public class LetterTransaction
	{
		public Guid? Letter_ID { get; set; }
		public Guid? Application_Code { get; set; }
		public string Application_NO { get; set; }
		public string Ref_No { get; set; }
		public string From { get; set; }
		public string To { get; set; }
		public bool? Is_IN { get; set; }
		public bool? IS_Out { get; set; }
		public string Subject { get; set; }
		public Int32? Number_Of_Page { get; set; }
		public Int32? Number_Of_Attachment { get; set; }
		public DateTime Letter_written_Date { get; set; }
		public string Document_Details { get; set; }
		public Guid? Recived_By { get; set; }
		public string RecivedBy_Name { get; set; }
	}
}
