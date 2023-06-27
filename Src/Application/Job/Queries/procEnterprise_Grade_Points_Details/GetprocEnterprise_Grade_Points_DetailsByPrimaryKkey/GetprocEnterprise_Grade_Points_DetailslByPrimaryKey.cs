using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Job.Quiries.procEnterprise_Grade_Points_Details.GetprocEnterprise_Grade_Points_DetailsLoadAll;

namespace Application.Job.Quiries.procEnterprise_Grade_Points_Details.GetprocEnterprise_Grade_Points_DetailsByPrimaryKkey
{
    /// @author  Shimels Alem proc_Job_SeekerLoadByPrimaryKey stored procedure.

    public class GetprocEnterprise_Grade_Points_DetailsByPrimaryKkey : IRequest<GetprocEnterprise_Grade_Points_DetailsLoadAllListVm>
    {
        public string ID { get; set; }
    }
}
