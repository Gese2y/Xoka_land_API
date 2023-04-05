using System;

namespace XOKA.Domain.Entities.Job
{
    public class MSEwarning
	{
		public System.Guid ID { get; set; }
		public string TIN { get; set; }
		public string Warning_Code { get; set; }
		public System.DateTime? Date_Issued { get; set; }
		public string Description { get; set; }
		public string Status { get; set; }

		public byte[] Warning_Letter_Doc { get; set; }

	}
}
