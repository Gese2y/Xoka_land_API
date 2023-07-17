


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Commands.procJob_Opportunity.procJob_OpportunityInsert.procJob_OpportunityInsertCommand
{

    /// @author  Shimels Alem  proc_MSE_EmployeeInsert stored procedure.


    public class procJob_OpportunityInsertCommand : IRequest<IList<Job_Opportunity_Id>>
    {
        public System.Guid Job_Opportunity_ID { get; set; }
        public string Stakeholder_TIN { get; set; }
        public string Job_Position { get; set; }
        public string Educ_Operand { get; set; }
        public string Educational_Level_ID { get; set; }
        public string Work_Exp_Operand { get; set; }
        public Nullable<double> Work_Experience_In_Years { get; set; }
        public string Gender_Criteria { get; set; }
        public string Description { get; set; }
        public string Type_Of_Hire { get; set; }
        public Nullable<System.DateTime> Date_Posted { get; set; }
        public Nullable<System.DateTime> Date_Expires { get; set; }  
        public Nullable<bool> Is_Active { get; set; }
        public string Remarks { get; set; }
        public string Education_Type { get; set; }
        public string Sector { get; set; }
        public string Sub_Sector { get; set; }
        public string Field_of_Business { get; set; }
        public Nullable<System.DateTime> Date_of_sending_to_the_employer_office { get; set; }
        public int number_of_person_requird { get; set; }

    }
		
		
		 
}
 
 