using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Tax.Quiries.procIncomeTax.GetprocIncomeTaxLoadAll;
using XOKA.Domain.Entities.Tax;
using XOKA.Domain.Interfaces;

namespace Application.Tax.Quiries.procIncomeTax.GetprocIncomeTaxByPrimaryKey
{
    public class GetprocIncomeTaxQueryHandler : IRequestHandler<GetprocIncomeTaxByPrimaryKey, GetprocIncomeTaxLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocIncomeTaxQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocIncomeTaxLoadAllListVm> Handle(GetprocIncomeTaxByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<IncomeTax> procIncomeTaxs = await _procedureAdabter
               .Execute<IncomeTax>("[Tax].[proc_Income_TaxLoadByPrimaryKey]", request);
            GetprocIncomeTaxLoadAllListVm vm = new GetprocIncomeTaxLoadAllListVm
            {
                procIncomeTaxs = _mapper.Map<IList<IncomeTax>, IList<GetprocIncomeTaxLoadAllVm>>(procIncomeTaxs)
            };

            return vm;
        }
    }
}
