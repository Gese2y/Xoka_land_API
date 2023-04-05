using System;

namespace XOKA.Domain.Entities.OCAC
{
    public class View_Exam_Result
	{
        public System.Guid ID { get; set; }
        public Nullable<System.Guid> OCAC_Exam_Cad_ID { get; set; }
        public Nullable<double> Result_In_Number { get; set; }
        public string Result_In_Text { get; set; }
        public Nullable<System.DateTime> Date_of_Exam { get; set; }
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
