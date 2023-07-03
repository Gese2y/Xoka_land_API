using System;

namespace XOKA.Domain.Entities.Job
{
    public class Sub_City_Job_Assignment_Transaction
	{
        public System.Guid Transaction_ID { get; set; }
        public Nullable<System.Guid> Job_Opportunity_ID { get; set; }
        public Nullable<System.Guid> Sub_City { get; set; }
        public Nullable<double> Number_Of_Person { get; set; }
        public string Approval_Justification_Doc { get; set; }
        public string Created_By { get; set; }

    }
}
