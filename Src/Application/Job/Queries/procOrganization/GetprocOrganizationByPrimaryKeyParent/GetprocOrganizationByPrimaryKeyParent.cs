using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Job.Quiries.procOrganization.GetprocOrganizationLoadAll;

namespace Application.Job.Quiries.procOrganization.GetprocOrganizationByPrimaryKeyParent
{
    /// @author  Shimels Alem proc_AssetsLoadByPrimaryKey stored procedure.

    public class GetprocOrganizationByPrimaryKeyParent : IRequest<GetprocOrganizationLoadAllListVm>
    {
        public string organizations_organization_code { get; set; }
    }
}
