using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Job.Quiries.procMSEwarning.GetprocMSEwarningLoadAll;

namespace Application.Job.Quiries.procMSEwarning.GetprocMSEwarningByPrimaryKey
{
    /// @author  Shimels Alem proc_MSE_EmployeeLoadByPrimaryKey stored procedure.

    public class GetprocMSEwarningByPrimaryKey : IRequest<GetprocMSEwarningLoadAllListVm>
    {
        public System.Guid ID { get; set; }
    }
}
