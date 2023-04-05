using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.TVET.Quiries.procShortTermTraining.GetprocShortTermTrainingLoadAll;

namespace Application.TVET.Quiries.procShortTermTraining.GetprocShortTermTrainingLoadByPrimaryKeyEMPTIN
{
    /// @author  Shimels Alem proc_Short_Term_TrainingLoadByPrimaryKey_EMP_TIN stored procedure.

    public class GetprocShortTermTrainingLoadByPrimaryKeyEMPTIN : IRequest<GetprocShortTermTrainingLoadAllListVm>
    {
        public string EMP_TIN { get; set; }
    }
}
