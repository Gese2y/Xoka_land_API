

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.TVET;
using XOKA.Domain.Interfaces;

namespace Application.TVET.Commands.procProgram.procProgramUpdate.procProgramUpdateCommand
{

    /// @author  Shimels Alem  proc_ProgramUpdate stored procedure.


    public class procProgramUpdateHandler : IRequestHandler<procProgramUpdateCommand, IList<Program_ProgramCode>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procProgramUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Program_ProgramCode>> Handle( procProgramUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<Program_ProgramCode> result = await _procedureAdabter
                .Execute<Program_ProgramCode>("[TVET].proc_ProgramUpdate", request);
           

            return result;
        }
    }
}
 