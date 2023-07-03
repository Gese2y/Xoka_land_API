using System;

namespace XOKA.Domain.Entities.view
{
    public class View_Job_Assignment_transaction
    {
        public System.Guid Transaction_ID { get; set; }
        public Nullable<System.Guid> Job_Opportunity_ID { get; set; }
        public Nullable<System.Guid> Woreda { get; set; }
        public Nullable<double> Number_Of_Person { get; set; }

    }
}
