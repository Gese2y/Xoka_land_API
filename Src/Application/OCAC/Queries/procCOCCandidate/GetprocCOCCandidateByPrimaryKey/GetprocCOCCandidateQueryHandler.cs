using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.OCAC.Quiries.procCOCCandidate.GetprocCOCCandidateLoadAll;
using XOKA.Domain.Entities.OCAC;
using XOKA.Domain.Interfaces;

namespace Application.OCAC.Quiries.procCOCCandidate.GetprocCOCCandidateByPrimaryKey
{
    public class GetprocCOCCandidateQueryHandler : IRequestHandler<GetprocCOCCandidateByPrimaryKey, GetprocCOCCandidateLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocCOCCandidateQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocCOCCandidateLoadAllListVm> Handle(GetprocCOCCandidateByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<COCCandidate> procCOCCandidates = await _procedureAdabter
               .Execute<COCCandidate>("[OCAC].[proc_COC_CandidateLoadByPrimaryKey]", request);
            GetprocCOCCandidateLoadAllListVm vm = new GetprocCOCCandidateLoadAllListVm
            {
                procCOCCandidates = _mapper.Map<IList<COCCandidate>, IList<GetprocCOCCandidateLoadAllVm>>(procCOCCandidates)
            };

            return vm;
        }
    }
}
