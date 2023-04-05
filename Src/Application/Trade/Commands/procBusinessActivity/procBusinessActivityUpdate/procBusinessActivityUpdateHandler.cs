

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Trade;
using XOKA.Domain.Interfaces;

namespace Application.Trade.Commands.procBusinessActivity.procBusinessActivityUpdate.procBusinessActivityUpdateCommand
{

    /// @author  Shimels Alem  proc_Business_ActivityUpdate stored procedure.


    public class procBusinessActivityUpdateHandler : IRequestHandler<procBusinessActivityUpdateCommand, IList<BusinessActivity_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procBusinessActivityUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<BusinessActivity_Code>> Handle( procBusinessActivityUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<BusinessActivity_Code> result = await _procedureAdabter
                .Execute<BusinessActivity_Code>("[Trade].proc_Business_ActivityUpdate", request);
           

            return result;
        }
    }
}
 