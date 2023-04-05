using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Trade.Quiries.procOccupationalStandard.GetprocOccupationalStandardLoadAll;

namespace Application.Trade.Quiries.procOccupationalStandard.GetprocOccupationalStandardByPrimaryKey
{
    /// @author  Shimels Alem proc_Occupational_StandardLoadByPrimaryKey stored procedure.

    public class GetprocOccupationalStandardByPrimaryKey : IRequest<GetprocOccupationalStandardLoadAllListVm>
    {
        public string OS_ID { get; set; }
    }
}
