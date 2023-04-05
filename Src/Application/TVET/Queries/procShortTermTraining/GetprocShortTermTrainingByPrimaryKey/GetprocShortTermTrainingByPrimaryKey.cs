using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.TVET.Quiries.procShortTermTraining.GetprocShortTermTrainingLoadAll;

namespace Application.TVET.Quiries.procShortTermTraining.GetprocShortTermTrainingByPrimaryKey
{
    /// @author  Shimels Alem proc_Short_Term_TrainingLoadByPrimaryKey stored procedure.

    public class GetprocShortTermTrainingByPrimaryKey : IRequest<GetprocShortTermTrainingLoadAllListVm>
    {
        public System.Guid ID { get; set; }
    }
}
