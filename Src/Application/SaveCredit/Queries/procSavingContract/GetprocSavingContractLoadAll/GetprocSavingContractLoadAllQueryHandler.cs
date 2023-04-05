using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.SaveCredit;
using XOKA.Domain.Interfaces;

namespace Application.SaveCredit.Quiries.procSavingContract.GetprocSavingContractLoadAll
{
    class GetprocSavingContractLoadAllQueryHandler : IRequestHandler<GetprocSavingContractLoadAllQuery, GetprocSavingContractLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocSavingContractLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocSavingContractLoadAllListVm> Handle(GetprocSavingContractLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<SavingContract> procSavingContracts = await _procedureAdabter
               .Execute<SavingContract>("[SaveCredit].[proc_Saving_ContractLoadAll]");
            GetprocSavingContractLoadAllListVm vm = new GetprocSavingContractLoadAllListVm
            {
                procSavingContracts = _mapper.Map<IList<SavingContract>, IList<GetprocSavingContractLoadAllVm>>(procSavingContracts)
            };

            return vm;
        }
    }
}
