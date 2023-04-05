using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Job.Quiries.procMSEwarning.GetprocMSEwarningLoadAll;

namespace Application.Job.Quiries.procMSEwarning.GetprocMSEwarningLoadByPrimaryKeyMSETIN
{
    /// @author  Shimels Alem proc_MSE_EmployeeLoadByPrimaryKey_MSE_TIN stored procedure.

    public class GetprocMSEwarningLoadByPrimaryKeyMSETIN : IRequest<GetprocMSEwarningLoadAllListVm>
    {
        public string TIN { get; set; }
    }
}
