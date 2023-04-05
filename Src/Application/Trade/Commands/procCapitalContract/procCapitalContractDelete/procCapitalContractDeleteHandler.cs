using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Trade;
using XOKA.Domain.Interfaces;

namespace Application.Trade.Commands.procCapitalContract.procCapitalContractDelete.procCapitalContractDeleteCommand
{

    /// @author  Shimels Alem  proc_Capital_ContractDelete stored procedure.


    public class procCapitalContractDeleteHandler : IRequestHandler<procCapitalContractDeleteCommand, IList<CapitalContract_ContractID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procCapitalContractDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CapitalContract_ContractID>> Handle( procCapitalContractDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<CapitalContract_ContractID> result = await _procedureAdabter
                .Execute<CapitalContract_ContractID>("[Trade].proc_Capital_ContractDelete", request);
           

            return result;
        }
    }
}
  