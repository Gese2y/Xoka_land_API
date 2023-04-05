using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.TVET;
using XOKA.Domain.Interfaces;

namespace Application.TVET.Quiries.procView_TVET_Result_Pop_UP.GetprocView_TVET_Result_Pop_UPLoadAll
{
    class GetprocView_TVET_Result_Pop_UPLoadAllQueryHandler : IRequestHandler<GetprocView_TVET_Result_Pop_UPLoadAllQuery, GetprocView_TVET_Result_Pop_UPLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocView_TVET_Result_Pop_UPLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocView_TVET_Result_Pop_UPLoadAllListVm> Handle(GetprocView_TVET_Result_Pop_UPLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<View_TVET_Result_Pop_UP> procView_TVET_Result_Pop_UPs = await _procedureAdabter
               .Execute<View_TVET_Result_Pop_UP>("[TVET].[View_TVET_Result_Pop_UP]");
            GetprocView_TVET_Result_Pop_UPLoadAllListVm vm = new GetprocView_TVET_Result_Pop_UPLoadAllListVm
            {
                procView_TVET_Result_Pop_UPs = _mapper.Map<IList<View_TVET_Result_Pop_UP>, IList<GetprocView_TVET_Result_Pop_UPLoadAllVm>>(procView_TVET_Result_Pop_UPs)
            };

            return vm;
        }
    }
}
