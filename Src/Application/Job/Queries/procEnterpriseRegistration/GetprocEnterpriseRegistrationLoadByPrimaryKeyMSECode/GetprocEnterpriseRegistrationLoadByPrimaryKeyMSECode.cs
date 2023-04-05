using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Job.Quiries.procEnterpriseRegistration.GetprocEnterpriseRegistrationLoadAll;

namespace Application.Job.Quiries.procEnterpriseRegistration.GetprocEnterpriseRegistrationLoadByPrimaryKeyMSECode
{
    /// @author  Shimels Alem proc_Enterprise_RegistrationLoadByPrimaryKey_MSE_Code stored procedure.

    public class GetprocEnterpriseRegistrationLoadByPrimaryKeyMSECode : IRequest<GetprocEnterpriseRegistrationLoadAllListVm>
    {
        public string MSE_Code { get; set; }
    }
}
