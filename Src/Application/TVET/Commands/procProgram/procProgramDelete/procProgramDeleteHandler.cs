using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.TVET;
using XOKA.Domain.Interfaces;

namespace Application.TVET.Commands.procProgram.procProgramDelete.procProgramDeleteCommand
{

    /// @author  Shimels Alem  proc_ProgramDelete stored procedure.


    public class procProgramDeleteHandler : IRequestHandler<procProgramDeleteCommand, IList<Program_ProgramCode>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procProgramDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Program_ProgramCode>> Handle( procProgramDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<Program_ProgramCode> result = await _procedureAdabter
                .Execute<Program_ProgramCode>("[TVET].proc_ProgramDelete", request);
           

            return result;
        }
    }
}
  