using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.TVET.Quiries.procProgram.GetprocProgramLoadAll;

namespace Application.TVET.Quiries.procProgram.GetprocProgramByPrimaryKey
{
    /// @author  Shimels Alem proc_ProgramLoadByPrimaryKey stored procedure.

    public class GetprocProgramByPrimaryKey : IRequest<GetprocProgramLoadAllListVm>
    {
        public string Program_Code { get; set; }
    }
}
