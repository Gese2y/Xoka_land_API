using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Trade.Quiries.procCapitalContract.GetprocCapitalContractLoadAll;
using XOKA.Domain.Entities.Trade;
using XOKA.Domain.Interfaces;

namespace Application.Trade.Quiries.procCapitalContract.GetprocCapitalContractByPrimaryKey
{
    public class GetprocCapitalContractQueryHandler : IRequestHandler<GetprocCapitalContractByPrimaryKey, GetprocCapitalContractLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocCapitalContractQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocCapitalContractLoadAllListVm> Handle(GetprocCapitalContractByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<CapitalContract> procCapitalContracts = await _procedureAdabter
               .Execute<CapitalContract>("[Trade].[proc_Capital_ContractLoadByPrimaryKey]", request);
            GetprocCapitalContractLoadAllListVm vm = new GetprocCapitalContractLoadAllListVm
            {
                procCapitalContracts = _mapper.Map<IList<CapitalContract>, IList<GetprocCapitalContractLoadAllVm>>(procCapitalContracts)
            };

            return vm;
        }
    }
}
