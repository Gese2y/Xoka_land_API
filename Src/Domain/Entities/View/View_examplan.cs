using System;

namespace XOKA.Domain.Entities.view
{
    public class View_examplan
    {
        public string Exam_ID { get; set; } 
        public string Name { get; set; }
        public string Pass_Mark { get; set; }
        public Nullable<System.DateTime> Start_Date { get; set; }
         public string Venue { get; set; }
        public string OS_ID { get; set; }
        public string Os_Name { get; set; }
        public string Centor_Code { get; set; }
        public string Exam_center_name { get; set; }
        public string Address { get; set; }

    }
}
