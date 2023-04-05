using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Trade;
using XOKA.Domain.Interfaces;

namespace Application.Trade.Quiries.procCompanyDetailAM.GetprocCompanyDetailAMLoadAll
{
    class GetprocCompanyDetailAMLoadAllQueryHandler : IRequestHandler<GetprocCompanyDetailAMLoadAllQuery, GetprocCompanyDetailAMLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocCompanyDetailAMLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocCompanyDetailAMLoadAllListVm> Handle(GetprocCompanyDetailAMLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<CompanyDetailAM> procCompanyDetailAMs = await _procedureAdabter
               .Execute<CompanyDetailAM>("[Trade].[proc_Company_Detail_AMLoadAll]");
            GetprocCompanyDetailAMLoadAllListVm vm = new GetprocCompanyDetailAMLoadAllListVm
            {
                procCompanyDetailAMs = _mapper.Map<IList<CompanyDetailAM>, IList<GetprocCompanyDetailAMLoadAllVm>>(procCompanyDetailAMs)
            };

            return vm;
        }
    }
}
