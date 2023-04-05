using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.UnEmployment.Quiries.procUnEmployee.GetprocUnEmployeeinfoLoadAll;
using XOKA.Domain.Entities.UnEmployment;
using XOKA.Domain.Interfaces;

namespace Application.UnEmployment.Quiries.procUnEmployee.GetprocUnEmployeeinfoLoadByPrimaryKeyVitalID
{
    public class GetprocUnEmployeeinfoQueryHandler : IRequestHandler<GetprocUnEmployeeinfoLoadByPrimaryKeyVitalID, GetprocUnEmployeeinfoLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocUnEmployeeinfoQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocUnEmployeeinfoLoadAllListVm> Handle(GetprocUnEmployeeinfoLoadByPrimaryKeyVitalID request, CancellationToken cancellationToken)
        {
           
            IList<UnEmployeeinfos> procUnEmployees = await _procedureAdabter
               .Execute<UnEmployeeinfos>("[UnEmployment].[proc_UnEmploymentinfoAllforNewEnterprisebyVitalID]", request);
            GetprocUnEmployeeinfoLoadAllListVm vm = new GetprocUnEmployeeinfoLoadAllListVm
            {
                procUnEmployees = _mapper.Map<IList<UnEmployeeinfos>, IList<GetprocUnEmployeeinfoLoadAllVm>>(procUnEmployees)
            };

            return vm;
        }
    }
}
