using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procJob_Match.procJob_MatchUpdate.procJob_MatchUpdateCommand
{

	/// @author  Shimels Alem  proc_MSE_EmployeeUpdate stored procedure.

	public class procJob_MatchUpdateCommand : IRequest<IList<Job_Match_Id>>
   {
        public System.Guid Job_Match_ID { get; set; }
        public Nullable<System.Guid> Transaction_ID { get; set; }
        public string Kebele_ID { get; set; }
        public string Officer_Proposed_Kebele_ID { get; set; }
        public string Officer_Justification { get; set; }
        public Nullable<System.DateTime> Date_Proposed { get; set; }
        public Nullable<bool> Is_Approved { get; set; }
        public string Approval_Justification_Doc { get; set; }
        public string Hired_Justification_Doc { get; set; }
        public Nullable<bool> Is_Hired { get; set; }
        public string Remarks { get; set; }
        public Nullable<bool> approved_by_sub_city { get; set; }
    }
		
		
		 
}

