using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Trade;
using XOKA.Domain.Interfaces;

namespace Application.Trade.Quiries.procCompanyDetailEN.GetprocCompanyDetailENLoadAll
{
    class GetprocCompanyDetailENLoadAllQueryHandler : IRequestHandler<GetprocCompanyDetailENLoadAllQuery, GetprocCompanyDetailENLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocCompanyDetailENLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocCompanyDetailENLoadAllListVm> Handle(GetprocCompanyDetailENLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<CompanyDetailEN> procCompanyDetailENs = await _procedureAdabter
               .Execute<CompanyDetailEN>("[Trade].[proc_Company_Detail_ENLoadAll]");
            GetprocCompanyDetailENLoadAllListVm vm = new GetprocCompanyDetailENLoadAllListVm
            {
                procCompanyDetailENs = _mapper.Map<IList<CompanyDetailEN>, IList<GetprocCompanyDetailENLoadAllVm>>(procCompanyDetailENs)
            };

            return vm;
        }
    }
}
