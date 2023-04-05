



using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.WorkSpace;
using XOKA.Domain.Interfaces;


namespace Application.WorkSpace.Commands.procLocationforBusOPP.procLocationforBusOPPInsert.procLocationforBusOPPInsertCommand
{

    /// @author  Shimels Alem  proc_Location_for_Bus_OPPInsert stored procedure.


    public class procLocationforBusOPPInsertHandler : IRequestHandler<procLocationforBusOPPInsertCommand, IList<LocationforBusOPP_BUSOPPLocCode>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procLocationforBusOPPInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<LocationforBusOPP_BUSOPPLocCode>> Handle( procLocationforBusOPPInsertCommand request, CancellationToken cancellationToken)
        {

            IList<LocationforBusOPP_BUSOPPLocCode> result = await _procedureAdabter
                .Execute<LocationforBusOPP_BUSOPPLocCode>("[WorkSpace].proc_Location_for_Bus_OPPInsert", request);
           

            return result;
        }
    }
}
 