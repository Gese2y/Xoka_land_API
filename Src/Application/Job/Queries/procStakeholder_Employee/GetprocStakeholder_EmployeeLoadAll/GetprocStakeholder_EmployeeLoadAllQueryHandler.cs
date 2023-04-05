using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Quiries.procStakeholder_Employee.GetprocStakeholder_EmployeeLoadAll
{
    class GetprocStakeholder_EmployeeLoadAllQueryHandler : IRequestHandler<GetprocStakeholder_EmployeeLoadAllQuery, GetprocStakeholder_EmployeeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocStakeholder_EmployeeLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocStakeholder_EmployeeLoadAllListVm> Handle(GetprocStakeholder_EmployeeLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Stakeholder_Employee> procStakeholder_Employees = await _procedureAdabter
               .Execute<Stakeholder_Employee>("[Job].[proc_Stakeholder_EmployeeLoadAll]");
            GetprocStakeholder_EmployeeLoadAllListVm vm = new GetprocStakeholder_EmployeeLoadAllListVm
            {
                procStakeholder_Employees = _mapper.Map<IList<Stakeholder_Employee>, IList<GetprocStakeholder_EmployeeLoadAllVm>>(procStakeholder_Employees)
            };

            return vm;
        }
    }
}
