

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Trade;
using XOKA.Domain.Interfaces;

namespace Application.Trade.Commands.procCommercialRegistration.procCommercialRegistrationUpdate.procCommercialRegistrationUpdateCommand
{

    /// @author  Shimels Alem  proc_Commercial_RegistrationUpdate stored procedure.


    public class procCommercialRegistrationUpdateHandler : IRequestHandler<procCommercialRegistrationUpdateCommand, IList<CommercialRegistration_COMREGNumber>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procCommercialRegistrationUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CommercialRegistration_COMREGNumber>> Handle( procCommercialRegistrationUpdateCommand request, CancellationToken cancellationToken)
        {
            
            IList<CommercialRegistration_COMREGNumber> result = await _procedureAdabter
                .Execute<CommercialRegistration_COMREGNumber>("[Trade].proc_Commercial_RegistrationUpdate",request);

            return result;
        }
    }
}
 