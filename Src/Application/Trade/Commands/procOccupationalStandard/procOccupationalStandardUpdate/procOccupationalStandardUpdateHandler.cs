

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Trade;
using XOKA.Domain.Interfaces;

namespace Application.Trade.Commands.procOccupationalStandard.procOccupationalStandardUpdate.procOccupationalStandardUpdateCommand
{

    /// @author  Shimels Alem  proc_Occupational_StandardUpdate stored procedure.


    public class procOccupationalStandardUpdateHandler : IRequestHandler<procOccupationalStandardUpdateCommand, IList<OccupationalStandard_OSID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procOccupationalStandardUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<OccupationalStandard_OSID>> Handle( procOccupationalStandardUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<OccupationalStandard_OSID> result = await _procedureAdabter
                .Execute<OccupationalStandard_OSID>("[Trade].proc_Occupational_StandardUpdate", request);
           

            return result;
        }
    }
}
 