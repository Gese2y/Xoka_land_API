using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Trade;
using XOKA.Domain.Interfaces;

namespace Application.Trade.Quiries.procCapitalContract.GetprocCapitalContractLoadAll
{
    class GetprocCapitalContractLoadAllQueryHandler : IRequestHandler<GetprocCapitalContractLoadAllQuery, GetprocCapitalContractLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocCapitalContractLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocCapitalContractLoadAllListVm> Handle(GetprocCapitalContractLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<CapitalContract> procCapitalContracts = await _procedureAdabter
               .Execute<CapitalContract>("[Trade].[proc_Capital_ContractLoadAll]");
            GetprocCapitalContractLoadAllListVm vm = new GetprocCapitalContractLoadAllListVm
            {
                procCapitalContracts = _mapper.Map<IList<CapitalContract>, IList<GetprocCapitalContractLoadAllVm>>(procCapitalContracts)
            };

            return vm;
        }
    }
}
