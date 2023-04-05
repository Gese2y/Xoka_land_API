using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Job.Quiries.procEnterpriseModelDetails.procEnterpriseModelDetailsLoadAll;

namespace Application.Job.Quiries.procEnterpriseModelDetails.procEnterpriseModelDetailsByPrimaryKey
{
    /// @author  Shimels Alem proc_Job_SeekerLoadByPrimaryKey stored procedure.

    public class GetprocEnterpriseModelDetailsByPrimaryKey : IRequest<GetprocEnterpriseModelDetailsLoadAllListVm>
    {
        public System.Guid Ent_Model_Detail_ID { get; set; }
    }
}
