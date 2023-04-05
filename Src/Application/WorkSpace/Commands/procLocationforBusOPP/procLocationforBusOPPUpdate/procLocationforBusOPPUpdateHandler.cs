

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.WorkSpace;
using XOKA.Domain.Interfaces;

namespace Application.WorkSpace.Commands.procLocationforBusOPP.procLocationforBusOPPUpdate.procLocationforBusOPPUpdateCommand
{

    /// @author  Shimels Alem  proc_Location_for_Bus_OPPUpdate stored procedure.


    public class procLocationforBusOPPUpdateHandler : IRequestHandler<procLocationforBusOPPUpdateCommand, IList<LocationforBusOPP_BUSOPPLocCode>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procLocationforBusOPPUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<LocationforBusOPP_BUSOPPLocCode>> Handle( procLocationforBusOPPUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<LocationforBusOPP_BUSOPPLocCode> result = await _procedureAdabter
                .Execute<LocationforBusOPP_BUSOPPLocCode>("[WorkSpace].proc_Location_for_Bus_OPPUpdate", request);
           

            return result;
        }
    }
}
 