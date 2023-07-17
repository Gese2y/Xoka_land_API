using System;

namespace XOKA.Domain.Entities.view
{
    public class View_jobopportunityapi
    {
        public string? Position_Name { get; set; }
        public string Name { get; set; }
        public Guid Job_Opportunity_ID { get; set; }
        public string? Stakeholder_TIN { get; set; }
        public string? Job_Position { get; set; }
        public string? Educ_Operand { get; set; }
        public string? Educational_Level_ID { get; set; }
        public string? Education_Type { get; set; }
        public string? Work_Exp_Operand { get; set; }
        public double? Work_Experience_In_Years { get; set; }
        public string? Gender_Criteria { get; set; }
        public string? Description { get; set; }
        public string? Type_Of_Hire { get; set; }
        public DateTime? Date_Posted { get; set; }
        public DateTime? Date_Expires { get; set; }
        public bool? Is_Active { get; set; }
        public string? Remarks { get; set; }
        public string? Sector { get; set; }
        public string? Sub_Sector { get; set; }
        public string? Field_of_Business { get; set; }
        public DateTime? Date_of_sending_to_the_employer_office { get; set; }
        public string? gendername { get; set; }
        public string? hiretypename { get; set; }
        public string? educationidname { get; set; }
        public int number_of_person_requird { get; set; }
        public string? WorkExpOperand { get; set; }
        public string? EducOperand { get; set; }
    }
}
