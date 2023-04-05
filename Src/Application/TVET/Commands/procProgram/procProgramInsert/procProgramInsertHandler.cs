



using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.TVET;
using XOKA.Domain.Interfaces;


namespace Application.TVET.Commands.procProgram.procProgramInsert.procProgramInsertCommand
{

    /// @author  Shimels Alem  proc_ProgramInsert stored procedure.


    public class procProgramInsertHandler : IRequestHandler<procProgramInsertCommand, IList<Program_ProgramCode>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procProgramInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Program_ProgramCode>> Handle( procProgramInsertCommand request, CancellationToken cancellationToken)
        {

            IList<Program_ProgramCode> result = await _procedureAdabter
                .Execute<Program_ProgramCode>("[TVET].proc_ProgramInsert", request);
           

            return result;
        }
    }
}
 