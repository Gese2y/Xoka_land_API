using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Job.Quiries.procJob_Position.GetprocJob_PositionLoadAll;

namespace Application.Job.Quiries.procJob_Position.GetprocJob_PositionByPrimaryKey
{
    /// @author  Shimels Alem proc_MSE_EmployeeLoadByPrimaryKey stored procedure.

    public class GetprocJob_PositionByPrimaryKey : IRequest<GetprocJob_PositionLoadAllListVm>
    {
        public string Job_Position_ID { get; set; }
    }
}
