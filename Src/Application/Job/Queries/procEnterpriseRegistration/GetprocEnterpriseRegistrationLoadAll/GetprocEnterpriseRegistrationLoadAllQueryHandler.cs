using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Quiries.procEnterpriseRegistration.GetprocEnterpriseRegistrationLoadAll
{
    class GetprocEnterpriseRegistrationLoadAllQueryHandler : IRequestHandler<GetprocEnterpriseRegistrationLoadAllQuery, GetprocEnterpriseRegistrationLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocEnterpriseRegistrationLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocEnterpriseRegistrationLoadAllListVm> Handle(GetprocEnterpriseRegistrationLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<EnterpriseRegistration> procEnterpriseRegistrations = await _procedureAdabter
               .Execute<EnterpriseRegistration>("[Job].[proc_Enterprise_RegistrationLoadAll]");
            GetprocEnterpriseRegistrationLoadAllListVm vm = new GetprocEnterpriseRegistrationLoadAllListVm
            {
                procEnterpriseRegistrations = _mapper.Map<IList<EnterpriseRegistration>, IList<GetprocEnterpriseRegistrationLoadAllVm>>(procEnterpriseRegistrations)
            };

            return vm;
        }
    }
}
