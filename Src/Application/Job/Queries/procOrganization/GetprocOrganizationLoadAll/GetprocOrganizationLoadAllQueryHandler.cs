using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Quiries.procOrganization.GetprocOrganizationLoadAll
{
    class GetprocOrganizationLoadAllQueryHandler : IRequestHandler<GetprocOrganizationLoadAllQuery, GetprocOrganizationLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocOrganizationLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocOrganizationLoadAllListVm> Handle(GetprocOrganizationLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Organization> procOrganizations = await _procedureAdabter
               .Execute<Organization>("[dbo].[proc_organizationsLoadAll]");
            GetprocOrganizationLoadAllListVm vm = new GetprocOrganizationLoadAllListVm
            {
                procOrganizations = _mapper.Map<IList<Organization>, IList<GetprocOrganizationLoadAllVm>>(procOrganizations)
            };

            return vm;
        }
    }
}
