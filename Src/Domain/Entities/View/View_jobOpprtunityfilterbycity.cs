using System;

namespace XOKA.Domain.Entities.view
{
    public class View_jobOpprtunityfilterbycity
    {
        public string Stakeholder_TIN { get; set; }
        public string Name { get; set; }
        public string Position_Name { get; set; }
        public Guid Job_Position { get; set; }
        public Guid Sub_City { get; set; }
        public string name_en { get; set; }
        public string name_am { get; set; }
        public double total_number_of_person { get; set; }
        public Guid Job_Opportunity_ID { get; set; }
        public string Result { get; set; }
        public double Number_Of_Person { get; set; }
        public double Subtraction_Result { get; set; }


    }
}
