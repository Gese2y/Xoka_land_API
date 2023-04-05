using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.SaveCredit.Quiries.procSavingContract.GetprocSavingContractLoadAll;
using XOKA.Domain.Entities.SaveCredit;
using XOKA.Domain.Interfaces;

namespace Application.SaveCredit.Quiries.procSavingContract.GetprocSavingContractLoadByPrimaryKeyLoanid
{
    public class GetprocSavingContractQueryHandler : IRequestHandler<GetprocSavingContractLoadByPrimaryKeyLoanid, GetprocSavingContractLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocSavingContractQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocSavingContractLoadAllListVm> Handle(GetprocSavingContractLoadByPrimaryKeyLoanid request, CancellationToken cancellationToken)
        {
           
            IList<SavingContract> procSavingContracts = await _procedureAdabter
               .Execute<SavingContract>("[SaveCredit].[proc_Saving_ContractLoadByPrimaryKey_Loan_id]", request);
            GetprocSavingContractLoadAllListVm vm = new GetprocSavingContractLoadAllListVm
            {
                procSavingContracts = _mapper.Map<IList<SavingContract>, IList<GetprocSavingContractLoadAllVm>>(procSavingContracts)
            };

            return vm;
        }
    }
}
