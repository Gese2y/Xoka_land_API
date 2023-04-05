using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Job.Quiries.procStakeholder.GetprocStakeholderLoadAll;

namespace Application.Job.Quiries.procStakeholder.GetprocStakeholderByPrimaryKey
{
    /// @author  Shimels Alem proc_MSE_EmployeeLoadByPrimaryKey stored procedure.

    public class GetprocStakeholderByPrimaryKey : IRequest<GetprocStakeholderLoadAllListVm>
    {
        public string Stakeholder_TIN { get; set; }

    }
}
