using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Trade;
using XOKA.Domain.Interfaces;

namespace Application.Trade.Quiries.procBusinessActivity.GetprocBusinessActivityLoadAll
{
    class GetprocBusinessActivityLoadAllQueryHandler : IRequestHandler<GetprocBusinessActivityLoadAllQuery, GetprocBusinessActivityLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocBusinessActivityLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocBusinessActivityLoadAllListVm> Handle(GetprocBusinessActivityLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<BusinessActivity> procBusinessActivitys = await _procedureAdabter
               .Execute<BusinessActivity>("[Trade].[proc_Business_ActivityLoadAll]");
            GetprocBusinessActivityLoadAllListVm vm = new GetprocBusinessActivityLoadAllListVm
            {
                procBusinessActivitys = _mapper.Map<IList<BusinessActivity>, IList<GetprocBusinessActivityLoadAllVm>>(procBusinessActivitys)
            };

            return vm;
        }
    }
}
