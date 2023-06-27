using System;

namespace XOKA.Domain.Entities.Job
{
    public partial class Enterprise_Grade_Points_Details
    {
        public string ID { get; set; }
        public DateTime Date_Graded { get; set; }
        public string Filled_By { get; set; }
        public string JSON_Value { get; set; }
        public string Enterprise_TIN { get; set; }
    }
}
