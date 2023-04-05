using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Quiries.procEnterpriseModelDetails.procEnterpriseModelDetailsLoadAll
{
    class GetprocEnterpriseModelDetailsLoadAllQueryHandler : IRequestHandler<GetprocEnterpriseModelDetailsLoadAllQuery, GetprocEnterpriseModelDetailsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocEnterpriseModelDetailsLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocEnterpriseModelDetailsLoadAllListVm> Handle(GetprocEnterpriseModelDetailsLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Enterprise_Model_Details> procEnterpriseModelDetails = await _procedureAdabter
               .Execute<Enterprise_Model_Details>("[dbo].[proc_Enterprise_Model_DetailsLoadAll]");
            GetprocEnterpriseModelDetailsLoadAllListVm vm = new GetprocEnterpriseModelDetailsLoadAllListVm
            {
                procEnterpriseModelDetails = _mapper.Map<IList<Enterprise_Model_Details>, IList<GetprocEnterpriseModelDetailsLoadAllVm>>(procEnterpriseModelDetails)
            };

            return vm;
        }
    }
}
