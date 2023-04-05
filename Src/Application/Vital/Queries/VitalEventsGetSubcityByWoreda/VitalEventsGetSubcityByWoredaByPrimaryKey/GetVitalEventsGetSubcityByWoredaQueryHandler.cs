using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Vital.Quiries.VitalEventsGetSubcityByWoreda.VitalEventsGetSubcityByWoredaLoadAll;
using XOKA.Domain.Entities.view;
using XOKA.Domain.Interfaces;

namespace Application.Vital.Quiries.VitalEventsGetSubcityByWoreda.GetVitalEventsGetSubcityByWoredaByPrimaryKey
{
    public class GetVitalEventsGetSubcityByWoredaQueryHandler : IRequestHandler<GetVitalEventsGetSubcityByWoredaByPrimaryKey, GetVitalEventsGetSubcityByWoredaOrgLoadListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetVitalEventsGetSubcityByWoredaQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetVitalEventsGetSubcityByWoredaOrgLoadListVm> Handle(GetVitalEventsGetSubcityByWoredaByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<VitalEventsGetSubcityByWoredaOrg> proVitalorg = await _procedureAdabter
               .Execute<VitalEventsGetSubcityByWoredaOrg>("[Vital].[proc_View_VitalEventsGetSubcityByWoredaOrg]", request);
            GetVitalEventsGetSubcityByWoredaOrgLoadListVm vm = new GetVitalEventsGetSubcityByWoredaOrgLoadListVm
            {
                proVitalorg = _mapper.Map<IList<VitalEventsGetSubcityByWoredaOrg>, IList<GetVitalEventsGetSubcityByWoredaOrgLoadAllVm>>(proVitalorg)
            };

            return vm;
        }
    }
}
