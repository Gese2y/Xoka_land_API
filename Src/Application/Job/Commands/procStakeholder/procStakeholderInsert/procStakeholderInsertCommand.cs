﻿


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Commands.procStakeholder.procStakeholderInsert.procStakeholderInsertCommand
{

    /// @author  Shimels Alem  proc_MSE_EmployeeInsert stored procedure.


    public class procStakeholderInsertCommand : IRequest<IList<Stakeholder_ID>>
    {
        public string Stakeholder_TIN { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Type_Of_Stakeholder { get; set; }
        public Nullable<bool> Is_SME { get; set; }
    }
		
		
		 
}
 
 