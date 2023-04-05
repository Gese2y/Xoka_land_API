using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Quiries.procEnterpriseGradeRenewal.GetprocEnterpriseGradeRenewalLoadAll
{
    class GetprocEnterpriseGradeRenewalLoadAllQueryHandler : IRequestHandler<GetprocEnterpriseGradeRenewalLoadAllQuery, GetprocEnterpriseGradeRenewalLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocEnterpriseGradeRenewalLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocEnterpriseGradeRenewalLoadAllListVm> Handle(GetprocEnterpriseGradeRenewalLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Enterprise_Grade_Renewal_Details> procEnterpriseGradeRenewal = await _procedureAdabter
               .Execute<Enterprise_Grade_Renewal_Details>("[dbo].[proc_Enterprise_Grade_Renewal_DetailsLoadAll]");
            GetprocEnterpriseGradeRenewalLoadAllListVm vm = new GetprocEnterpriseGradeRenewalLoadAllListVm
            {
                procEnterpriseGradeRenewal = _mapper.Map<IList<Enterprise_Grade_Renewal_Details>, IList<GetprocEnterpriseGradeRenewalLoadAllVm>>(procEnterpriseGradeRenewal)
            };

            return vm;
        }
    }
}
