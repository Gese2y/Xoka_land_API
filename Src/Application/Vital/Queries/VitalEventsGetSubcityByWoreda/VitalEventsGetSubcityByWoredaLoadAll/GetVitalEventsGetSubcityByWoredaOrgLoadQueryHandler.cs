using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.view;
using XOKA.Domain.Interfaces;

namespace Application.Vital.Quiries.VitalEventsGetSubcityByWoreda.VitalEventsGetSubcityByWoredaLoadAll
{
    class GetVitalEventsGetSubcityByWoredaOrgLoadQueryHandler : IRequestHandler<GetVitalEventsGetSubcityByWoredaOrgLoadAllQuery, GetVitalEventsGetSubcityByWoredaOrgLoadListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetVitalEventsGetSubcityByWoredaOrgLoadQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetVitalEventsGetSubcityByWoredaOrgLoadListVm> Handle(GetVitalEventsGetSubcityByWoredaOrgLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<VitalEventsGetSubcityByWoredaOrg> proVitalorg = await _procedureAdabter
               .Execute<VitalEventsGetSubcityByWoredaOrg>("[Vital].[proc_vitallogLoadAll]");
            GetVitalEventsGetSubcityByWoredaOrgLoadListVm vm = new GetVitalEventsGetSubcityByWoredaOrgLoadListVm
            {
                proVitalorg = _mapper.Map<IList<VitalEventsGetSubcityByWoredaOrg>, IList<GetVitalEventsGetSubcityByWoredaOrgLoadAllVm>>(proVitalorg)
            };

            return vm;
        }
    }
}
