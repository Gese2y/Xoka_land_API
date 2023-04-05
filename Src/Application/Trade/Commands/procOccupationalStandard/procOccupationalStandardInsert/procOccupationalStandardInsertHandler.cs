



using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Trade;
using XOKA.Domain.Interfaces;


namespace Application.Trade.Commands.procOccupationalStandard.procOccupationalStandardInsert.procOccupationalStandardInsertCommand
{

    /// @author  Shimels Alem  proc_Occupational_StandardInsert stored procedure.


    public class procOccupationalStandardInsertHandler : IRequestHandler<procOccupationalStandardInsertCommand, IList<OccupationalStandard_OSID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procOccupationalStandardInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<OccupationalStandard_OSID>> Handle( procOccupationalStandardInsertCommand request, CancellationToken cancellationToken)
        {

            IList<OccupationalStandard_OSID> result = await _procedureAdabter
                .Execute<OccupationalStandard_OSID>("[Trade].proc_Occupational_StandardInsert", request);
           

            return result;
        }
    }
}
 