using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Job.Quiries.procEnterpriseGradeRenewal.GetprocEnterpriseGradeRenewalLoadAll;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Quiries.procEnterpriseGradeRenewal.GetprocEnterpriseGradeRenewalByPrimaryKey
{
    public class GetprocEnterpriseGradeRenewalQueryHandler : IRequestHandler<GetprocEnterpriseGradeRenewalByPrimaryKey, GetprocEnterpriseGradeRenewalLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocEnterpriseGradeRenewalQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocEnterpriseGradeRenewalLoadAllListVm> Handle(GetprocEnterpriseGradeRenewalByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<Enterprise_Grade_Renewal_Details> procEnterpriseGradeRenewal = await _procedureAdabter
               .Execute<Enterprise_Grade_Renewal_Details>("[dbo].[proc_Enterprise_Grade_Renewal_DetailsLoadByPrimaryKey]", request);
            GetprocEnterpriseGradeRenewalLoadAllListVm vm = new GetprocEnterpriseGradeRenewalLoadAllListVm
            {
                procEnterpriseGradeRenewal = _mapper.Map<IList<Enterprise_Grade_Renewal_Details>, IList<GetprocEnterpriseGradeRenewalLoadAllVm>>(procEnterpriseGradeRenewal)
            };

            return vm;
        }
    }
}
