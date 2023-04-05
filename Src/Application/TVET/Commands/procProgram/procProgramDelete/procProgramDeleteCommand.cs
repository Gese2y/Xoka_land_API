 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.TVET;

namespace Application.TVET.Commands.procProgram.procProgramDelete.procProgramDeleteCommand
{

    // @author  Shimels Alem  proc_ProgramDelete stored procedure.

    public class procProgramDeleteCommand : IRequest<IList<Program_ProgramCode>>
    {
        public string Program_Code { get; set; }
    }
		
     
		
		 
}
 
 