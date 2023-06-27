using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Job.Quiries.procEnterprise_Grade_Points_Details.GetprocEnterprise_Grade_Points_DetailsLoadAll;

namespace Application.Job.Quiries.procEnterprise_Grade_Points_Details.GetprocEnterprise_Grade_Points_DetailsByPrimaryKey
{
    /// @author  Shimels Alem proc_Job_SeekerLoadByPrimaryKey stored procedure.

    public class GetprocEnterprise_Grade_Points_DetailsByPrimaryKey : IRequest<GetprocEnterprise_Grade_Points_DetailsLoadAllListVm>
    {
        public string Enterprise_TIN { get; set; }
    }
}
