using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Job.Quiries.procOrganization.GetprocOrganizationLoadAll;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Quiries.procOrganization.GetprocOrganizationByPrimaryKeyParent
{
    public class GetprocOrganizationQueryHandler : IRequestHandler<GetprocOrganizationByPrimaryKeyParent, GetprocOrganizationLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocOrganizationQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocOrganizationLoadAllListVm> Handle(GetprocOrganizationByPrimaryKeyParent request, CancellationToken cancellationToken)
        {
           
            IList<Organization> procOrganizations = await _procedureAdabter
               .Execute<Organization>("[dbo].[proc_organizationsLoadByPrimaryKey_Parent]", request);
            GetprocOrganizationLoadAllListVm vm = new GetprocOrganizationLoadAllListVm
            {
                procOrganizations = _mapper.Map<IList<Organization>, IList<GetprocOrganizationLoadAllVm>>(procOrganizations)
            };

            return vm;
        }
    }
}
