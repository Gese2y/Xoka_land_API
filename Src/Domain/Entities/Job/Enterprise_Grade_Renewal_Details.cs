using System;

namespace XOKA.Domain.Entities.Job
{
    public partial class Enterprise_Grade_Renewal_Details
    {
        public System.Guid Ent_Grading_Detail_ID { get; set; }
        public string Code { get; set; }
        public string TIN { get; set; }
        public byte[] Grading_Letter { get; set; }
        public Nullable<System.DateTime> Date_Of_Grade_Issued { get; set; }
        public string Remarks { get; set; }
    }
}
