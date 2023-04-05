using System;

namespace XOKA.Domain.Entities.view
{
    public class View_jobassignment_transaction
    {
        public string Name { get; set; }
        public Nullable<System.Guid> Woreda { get; set; }
        public Nullable<double> Number_Of_Person { get; set; }
        public string Approval_Justification_Doc { get; set; }
        public string Job_Position { get; set; }
        public string name_am { get; set; }
        public string name_amsubcity { get; set; }
        public System.Guid organization_code { get; set; }
        public Nullable<System.Guid> Job_Opportunity_ID { get; set; }
        public string Stakeholder_TIN { get; set; }
        public string Position_Name { get; set; }
        public System.Guid Transaction_ID { get; set; }
        public System.Guid organization_codeforsubcity { get; set; }

    }
}
