using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.SaveCredit;
using XOKA.Domain.Interfaces;

namespace Application.SaveCredit.Commands.procSavingContract.procSavingContractDelete.procSavingContractDeleteCommand
{

    /// @author  Shimels Alem  proc_Saving_ContractDelete stored procedure.


    public class procSavingContractDeleteHandler : IRequestHandler<procSavingContractDeleteCommand, IList<SavingContract_contractid>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procSavingContractDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<SavingContract_contractid>> Handle( procSavingContractDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<SavingContract_contractid> result = await _procedureAdabter
                .Execute<SavingContract_contractid>("[SaveCredit].proc_Saving_ContractDelete", request);
           

            return result;
        }
    }
}
  