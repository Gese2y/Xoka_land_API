using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.OCAC;
using XOKA.Domain.Interfaces;

namespace Application.OCAC.Quiries.procOCACExamCandidate.GetprocOCACExamCandidateLoadAll
{
    class GetprocOCACExamCandidateLoadAllQueryHandler : IRequestHandler<GetprocOCACExamCandidateLoadAllQuery, GetprocOCACExamCandidateLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocOCACExamCandidateLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocOCACExamCandidateLoadAllListVm> Handle(GetprocOCACExamCandidateLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<OCACExamCandidate> procOCACExamCandidates = await _procedureAdabter
               .Execute<OCACExamCandidate>("[OCAC].[proc_OCAC_Exam__CandidateLoadAll]");
            GetprocOCACExamCandidateLoadAllListVm vm = new GetprocOCACExamCandidateLoadAllListVm
            {
                procOCACExamCandidates = _mapper.Map<IList<OCACExamCandidate>, IList<GetprocOCACExamCandidateLoadAllVm>>(procOCACExamCandidates)
            };

            return vm;
        }
    }
}
