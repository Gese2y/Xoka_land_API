using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Quiries.procMSEEmployee.GetprocMSEEmployeeLoadAll
{
    class GetprocMSEEmployeeLoadAllQueryHandler : IRequestHandler<GetprocMSEEmployeeLoadAllQuery, GetprocMSEEmployeeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocMSEEmployeeLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocMSEEmployeeLoadAllListVm> Handle(GetprocMSEEmployeeLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<MSEEmployee> procMSEEmployees = await _procedureAdabter
               .Execute<MSEEmployee>("[Job].[proc_MSE_EmployeeLoadAll]");
            GetprocMSEEmployeeLoadAllListVm vm = new GetprocMSEEmployeeLoadAllListVm
            {
                procMSEEmployees = _mapper.Map<IList<MSEEmployee>, IList<GetprocMSEEmployeeLoadAllVm>>(procMSEEmployees)
            };

            return vm;
        }
    }
}
