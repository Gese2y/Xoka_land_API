using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Vital.Quiries.procVitalEvents.GetprocVitalEventsLoadAll;
using XOKA.Domain.Entities.Vital;
using XOKA.Domain.Interfaces;

namespace Application.Vital.Quiries.procVitalEvents.GetprocVitalEventsLoadByPrimaryKeyLicenceID
{
    public class GetprocVitalEventsQueryHandler : IRequestHandler<GetprocVitalEventsLoadByPrimaryKeyLicenceID, GetprocVitalEventsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocVitalEventsQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocVitalEventsLoadAllListVm> Handle(GetprocVitalEventsLoadByPrimaryKeyLicenceID request, CancellationToken cancellationToken)
        {
           
            IList<VitalEvents> procVitalEventss = await _procedureAdabter
               .Execute<VitalEvents>("[Vital].[proc_Vital_EventsLoadByPrimaryKey_Licence_ID]", request);
            GetprocVitalEventsLoadAllListVm vm = new GetprocVitalEventsLoadAllListVm
            {
                procVitalEventss = _mapper.Map<IList<VitalEvents>, IList<GetprocVitalEventsLoadAllVm>>(procVitalEventss)
            };

            return vm;
        }
    }
}
