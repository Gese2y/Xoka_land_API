using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.UnEmployment;
using XOKA.Domain.Interfaces;

namespace Application.UnEmployment.Quiries.procUnEmployee.GetprocUnEmployeeLoadAll
{
    class GetprocUnEmployeeLoadAllQueryHandler : IRequestHandler<GetprocUnEmployeeLoadAllQuery, GetprocUnEmployeeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocUnEmployeeLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocUnEmployeeLoadAllListVm> Handle(GetprocUnEmployeeLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<UnEmployee> procUnEmployees = await _procedureAdabter
               .Execute<UnEmployee>("[UnEmployment].[proc_UnEmployeeLoadAll]");
            GetprocUnEmployeeLoadAllListVm vm = new GetprocUnEmployeeLoadAllListVm
            {
                procUnEmployees = _mapper.Map<IList<UnEmployee>, IList<GetprocUnEmployeeLoadAllVm>>(procUnEmployees)
            };

            return vm;
        }
    }
}
