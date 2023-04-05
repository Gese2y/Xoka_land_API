



using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Trade;
using XOKA.Domain.Interfaces;


namespace Application.Trade.Commands.procCommercialRegistration.procCommercialRegistrationInsert.procCommercialRegistrationInsertCommand
{

    /// @author  Shimels Alem  proc_Commercial_RegistrationInsert stored procedure.


    public class procCommercialRegistrationInsertHandler : IRequestHandler<procCommercialRegistrationInsertCommand, IList<CommercialRegistration_COMREGNumber>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procCommercialRegistrationInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CommercialRegistration_COMREGNumber>> Handle( procCommercialRegistrationInsertCommand request, CancellationToken cancellationToken)
        {

            IList<CommercialRegistration_COMREGNumber> result = await _procedureAdabter
                .Execute<CommercialRegistration_COMREGNumber>("[Trade].proc_Commercial_RegistrationInsert", request);
           

            return result;
        }
    }
}
 