using System;

namespace XOKA.Domain.Entities.Job
{
    public partial class Enterprise_Model_Details
    {
        public System.Guid Ent_Model_Detail_ID { get; set; }
        public string TIN { get; set; }
        public byte[] Model_Evaluation_Letter { get; set; }
        public Nullable<System.DateTime> Date_Of_Model_Selection { get; set; }
        public Nullable<double> Point_Earned { get; set; }
        public string Remarks { get; set; }
    }
}
