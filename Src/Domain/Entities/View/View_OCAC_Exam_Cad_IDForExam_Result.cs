using System;

namespace XOKA.Domain.Entities.view
{
    public partial class View_OCAC_Exam_Cad_IDForExam_Result
    {
        public string Student { get; set; }
        public string Exam_center { get; set; }
        public string Exam_Name { get; set; }
        public Nullable<System.DateTime> Start_Date { get; set; }
        public string Enrolment_ID { get; set; }
        public string ID_No { get; set; }
        public string First_Name_AM { get; set; }
        public string Middle_Name_AM { get; set; }
        public string Last_Name_AM { get; set; }
        public string Program_Name { get; set; }
        public string Program { get; set; }
        public System.Guid OCAC_Candiate { get; set; }
        public System.Guid Licence_Id { get; set; }
    }
}
