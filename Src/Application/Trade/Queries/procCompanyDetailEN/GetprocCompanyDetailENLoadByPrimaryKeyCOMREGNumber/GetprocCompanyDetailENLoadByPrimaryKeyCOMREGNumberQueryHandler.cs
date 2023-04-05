using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Trade.Quiries.procCompanyDetailEN.GetprocCompanyDetailENLoadAll;
using XOKA.Domain.Entities.Trade;
using XOKA.Domain.Interfaces;

namespace Application.Trade.Quiries.procCompanyDetailEN.GetprocCompanyDetailENLoadByPrimaryKeyCOMREGNumber
{
    public class GetprocCompanyDetailENQueryHandler : IRequestHandler<GetprocCompanyDetailENLoadByPrimaryKeyCOMREGNumber, GetprocCompanyDetailENLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocCompanyDetailENQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocCompanyDetailENLoadAllListVm> Handle(GetprocCompanyDetailENLoadByPrimaryKeyCOMREGNumber request, CancellationToken cancellationToken)
        {
           
            IList<CompanyDetailEN> procCompanyDetailENs = await _procedureAdabter
               .Execute<CompanyDetailEN>("[Trade].[proc_Company_Detail_ENLoadByPrimaryKey_COM_REG_Number]", request);
            GetprocCompanyDetailENLoadAllListVm vm = new GetprocCompanyDetailENLoadAllListVm
            {
                procCompanyDetailENs = _mapper.Map<IList<CompanyDetailEN>, IList<GetprocCompanyDetailENLoadAllVm>>(procCompanyDetailENs)
            };

            return vm;
        }
    }
}
