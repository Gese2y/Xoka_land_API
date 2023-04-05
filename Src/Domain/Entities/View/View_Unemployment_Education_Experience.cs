using System;

namespace XOKA.Domain.Entities.view
{
    public class View_Unemployment_Education_Experience
    {
        public string? Vital_ID { get; set; } 
        public string? TIN { get; set; }
        public string? Full_Name { get; set; }
         public string? Status { get; set; }
        public string? Unemployment_Number { get; set; }
        public string? Physical_Condition { get; set; }
        public string? Refugee_Status { get; set; }
        public string? HIV_Status { get; set; }
        public string? Returnee_Status { get; set; }
        public string? Gender { get; set; }
        public string? Level { get; set; }
        public string? Position_Name { get; set; }
        public string? Eduction_Types { get; set; }
        public string? Job_Position_ID { get; set; }
        public Nullable<System.DateTime> Start_Date { get; set; } 
        public Nullable<System.DateTime> End_Date { get; set; }
        public double? basic_Salary { get; set; }
        public int? Num_Years { get; set; }

    }
}
