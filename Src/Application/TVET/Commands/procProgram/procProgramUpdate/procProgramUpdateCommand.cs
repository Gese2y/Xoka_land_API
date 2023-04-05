using AutoMapper;
using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.TVET;

namespace Application.TVET.Commands.procProgram.procProgramUpdate.procProgramUpdateCommand
{

    /// @author  Shimels Alem  proc_ProgramUpdate stored procedure.

    public class procProgramUpdateCommand : IRequest<IList<Program_ProgramCode>>
   {
        public string Program_Code { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Level { get; set; }
        public int? Period_In_Day { get; set; }
        public string Program_Major { get; set; }
        public System.Double? MIN_Total_Credit { get; set; }
    }
		
		
		 
}

