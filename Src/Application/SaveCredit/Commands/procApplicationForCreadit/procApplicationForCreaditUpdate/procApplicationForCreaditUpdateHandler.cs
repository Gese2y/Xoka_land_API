

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.SaveCredit;
using XOKA.Domain.Interfaces;

namespace Application.SaveCredit.Commands.procApplicationForCreadit.procApplicationForCreaditUpdate.procApplicationForCreaditUpdateCommand
{

    /// @author  Shimels Alem  proc_Application_For_CreaditUpdate stored procedure.


    public class procApplicationForCreaditUpdateHandler : IRequestHandler<procApplicationForCreaditUpdateCommand, IList<ApplicationForCreadit_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procApplicationForCreaditUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<ApplicationForCreadit_ID>> Handle( procApplicationForCreaditUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<ApplicationForCreadit_ID> result = await _procedureAdabter
                .Execute<ApplicationForCreadit_ID>("[SaveCredit].proc_Application_For_CreaditUpdate", request);
           

            return result;
        }
    }
}
 