

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.SaveCredit;
using XOKA.Domain.Interfaces;

namespace Application.SaveCredit.Commands.procSavingContract.procSavingContractUpdate.procSavingContractUpdateCommand
{

    /// @author  Shimels Alem  proc_Saving_ContractUpdate stored procedure.


    public class procSavingContractUpdateHandler : IRequestHandler<procSavingContractUpdateCommand, IList<SavingContract_contractid>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procSavingContractUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<SavingContract_contractid>> Handle( procSavingContractUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<SavingContract_contractid> result = await _procedureAdabter
                .Execute<SavingContract_contractid>("[SaveCredit].proc_Saving_ContractUpdate", request);
           

            return result;
        }
    }
}
 