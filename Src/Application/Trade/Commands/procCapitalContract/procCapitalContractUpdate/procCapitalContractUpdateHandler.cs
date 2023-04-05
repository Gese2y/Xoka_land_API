

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Trade;
using XOKA.Domain.Interfaces;

namespace Application.Trade.Commands.procCapitalContract.procCapitalContractUpdate.procCapitalContractUpdateCommand
{

    /// @author  Shimels Alem  proc_Capital_ContractUpdate stored procedure.


    public class procCapitalContractUpdateHandler : IRequestHandler<procCapitalContractUpdateCommand, IList<CapitalContract_ContractID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procCapitalContractUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CapitalContract_ContractID>> Handle( procCapitalContractUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<CapitalContract_ContractID> result = await _procedureAdabter
                .Execute<CapitalContract_ContractID>("[Trade].proc_Capital_ContractUpdate", request);
           

            return result;
        }
    }
}
 