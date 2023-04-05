using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Trade.Quiries.procBusinessActivity.GetprocBusinessActivityLoadAll;
using XOKA.Domain.Entities.Trade;
using XOKA.Domain.Interfaces;

namespace Application.Trade.Quiries.procBusinessActivity.GetprocBusinessActivityByPrimaryKey
{
    public class GetprocBusinessActivityQueryHandler : IRequestHandler<GetprocBusinessActivityByPrimaryKey, GetprocBusinessActivityLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocBusinessActivityQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocBusinessActivityLoadAllListVm> Handle(GetprocBusinessActivityByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<BusinessActivity> procBusinessActivitys = await _procedureAdabter
               .Execute<BusinessActivity>("[Trade].[proc_Business_ActivityLoadByPrimaryKey]", request);
            GetprocBusinessActivityLoadAllListVm vm = new GetprocBusinessActivityLoadAllListVm
            {
                procBusinessActivitys = _mapper.Map<IList<BusinessActivity>, IList<GetprocBusinessActivityLoadAllVm>>(procBusinessActivitys)
            };

            return vm;
        }
    }
}
