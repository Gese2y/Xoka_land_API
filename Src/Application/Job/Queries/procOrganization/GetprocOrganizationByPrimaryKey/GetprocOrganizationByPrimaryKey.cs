using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Job.Quiries.procOrganization.GetprocOrganizationLoadAll;

namespace Application.Job.Quiries.procOrganization.GetprocOrganizationByPrimaryKey
{
    /// @author  Shimels Alem proc_AssetsLoadByPrimaryKey stored procedure.

    public class GetprocOrganizationByPrimaryKey : IRequest<GetprocOrganizationLoadAllListVm>
    {
        public string organization_code { get; set; }
    }
}
