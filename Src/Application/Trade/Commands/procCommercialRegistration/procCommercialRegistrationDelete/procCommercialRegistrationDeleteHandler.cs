using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Trade;
using XOKA.Domain.Interfaces;

namespace Application.Trade.Commands.procCommercialRegistration.procCommercialRegistrationDelete.procCommercialRegistrationDeleteCommand
{

    /// @author  Shimels Alem  proc_Commercial_RegistrationDelete stored procedure.


    public class procCommercialRegistrationDeleteHandler : IRequestHandler<procCommercialRegistrationDeleteCommand, IList<CommercialRegistration_COMREGNumber>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procCommercialRegistrationDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CommercialRegistration_COMREGNumber>> Handle( procCommercialRegistrationDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<CommercialRegistration_COMREGNumber> result = await _procedureAdabter
                .Execute<CommercialRegistration_COMREGNumber>("[Trade].proc_Commercial_RegistrationDelete", request);
           

            return result;
        }
    }
}
  