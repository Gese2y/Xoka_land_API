using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Job.Quiries.procEnterpriseRegistration.GetprocEnterpriseRegistrationLoadAll;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Quiries.procEnterpriseRegistration.GetprocEnterpriseRegistrationByPrimaryKey
{
    public class GetprocEnterpriseRegistrationQueryHandler : IRequestHandler<GetprocEnterpriseRegistrationByPrimaryKey, GetprocEnterpriseRegistrationLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocEnterpriseRegistrationQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocEnterpriseRegistrationLoadAllListVm> Handle(GetprocEnterpriseRegistrationByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<EnterpriseRegistration> procEnterpriseRegistrations = await _procedureAdabter
               .Execute<EnterpriseRegistration>("[Job].[proc_Enterprise_RegistrationLoadByPrimaryKey]", request);
            GetprocEnterpriseRegistrationLoadAllListVm vm = new GetprocEnterpriseRegistrationLoadAllListVm
            {
                procEnterpriseRegistrations = _mapper.Map<IList<EnterpriseRegistration>, IList<GetprocEnterpriseRegistrationLoadAllVm>>(procEnterpriseRegistrations)
            };

            return vm;
        }
    }
}
