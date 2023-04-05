using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Trade;
using XOKA.Domain.Interfaces;

namespace Application.Trade.Commands.procBusinessActivity.procBusinessActivityDelete.procBusinessActivityDeleteCommand
{

    /// @author  Shimels Alem  proc_Business_ActivityDelete stored procedure.


    public class procBusinessActivityDeleteHandler : IRequestHandler<procBusinessActivityDeleteCommand, IList<BusinessActivity_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procBusinessActivityDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<BusinessActivity_Code>> Handle( procBusinessActivityDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<BusinessActivity_Code> result = await _procedureAdabter
                .Execute<BusinessActivity_Code>("[Trade].proc_Business_ActivityDelete", request);
           

            return result;
        }
    }
}
  