using System;

namespace XOKA.Domain.Entities.view
{

    public partial class View_Exam_Result_Certificat
    {
        public System.Guid ID { get; set; }
        public Nullable<System.Guid> Exam_Result_Id { get; set; }
        public string TEVET_Program_ID { get; set; }
        public Nullable<System.DateTime> Date_Issued { get; set; }
        public Nullable<System.DateTime> Expired_Date { get; set; }
        public Nullable<bool> Is_Summitted_To_candidate { get; set; }
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
        public Nullable<double> Result_In_Number { get; set; }
        public string Result_In_Text { get; set; }
    }
}
