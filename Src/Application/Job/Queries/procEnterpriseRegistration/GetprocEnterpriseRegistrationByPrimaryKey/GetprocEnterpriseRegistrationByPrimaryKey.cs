using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Job.Quiries.procEnterpriseRegistration.GetprocEnterpriseRegistrationLoadAll;

namespace Application.Job.Quiries.procEnterpriseRegistration.GetprocEnterpriseRegistrationByPrimaryKey
{
    /// @author  Shimels Alem proc_Enterprise_RegistrationLoadByPrimaryKey stored procedure.

    public class GetprocEnterpriseRegistrationByPrimaryKey : IRequest<GetprocEnterpriseRegistrationLoadAllListVm>
    {
        public string TIN { get; set; }
    }
}
