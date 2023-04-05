using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Vital;
using XOKA.Domain.Interfaces;

namespace Application.Vital.Quiries.procVitalEvents.GetprocVitalEventsLoadAll
{
    class GetprocVitalEventsLoadAllQueryHandler : IRequestHandler<GetprocVitalEventsLoadAllQuery, GetprocVitalEventsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocVitalEventsLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocVitalEventsLoadAllListVm> Handle(GetprocVitalEventsLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<VitalEvents> procVitalEventss = await _procedureAdabter
               .Execute<VitalEvents>("[Vital].[proc_Vital_EventsLoadAll]");
            GetprocVitalEventsLoadAllListVm vm = new GetprocVitalEventsLoadAllListVm
            {
                procVitalEventss = _mapper.Map<IList<VitalEvents>, IList<GetprocVitalEventsLoadAllVm>>(procVitalEventss)
            };

            return vm;
        }
    }
}
