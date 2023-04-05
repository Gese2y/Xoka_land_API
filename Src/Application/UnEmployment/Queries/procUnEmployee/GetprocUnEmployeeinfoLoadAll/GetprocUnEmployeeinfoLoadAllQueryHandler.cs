using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.UnEmployment;
using XOKA.Domain.Interfaces;

namespace Application.UnEmployment.Quiries.procUnEmployee.GetprocUnEmployeeinfoLoadAll
{
    class GetprocUnEmployeeinfoLoadAllQueryHandler : IRequestHandler<GetprocUnEmployeeinfoLoadAllQuery, GetprocUnEmployeeinfoLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocUnEmployeeinfoLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocUnEmployeeinfoLoadAllListVm> Handle(GetprocUnEmployeeinfoLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<UnEmployeeinfos> procUnEmployees = await _procedureAdabter
               .Execute<UnEmployeeinfos>("[UnEmployment].[proc_UnEmploymentinfoAllforNewEnterprise]");
            GetprocUnEmployeeinfoLoadAllListVm vm = new GetprocUnEmployeeinfoLoadAllListVm
            {
                procUnEmployees = _mapper.Map<IList<UnEmployeeinfos>, IList<GetprocUnEmployeeinfoLoadAllVm>>(procUnEmployees)
            };

            return vm;
        }
    }
}
