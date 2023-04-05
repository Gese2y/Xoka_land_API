using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.OCAC.Quiries.procOCACExamCandidate.GetprocOCACExamCandidateLoadAll;
using XOKA.Domain.Entities.OCAC;
using XOKA.Domain.Interfaces;

namespace Application.OCAC.Quiries.procOCACExamCandidate.GetprocOCACExamCandidateLoadByPrimaryKeyOCACExamPlanID
{
    public class GetprocOCACExamCandidateQueryHandler : IRequestHandler<GetprocOCACExamCandidateLoadByPrimaryKeyOCACExamPlanID, GetprocOCACExamCandidateLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocOCACExamCandidateQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocOCACExamCandidateLoadAllListVm> Handle(GetprocOCACExamCandidateLoadByPrimaryKeyOCACExamPlanID request, CancellationToken cancellationToken)
        {
           
            IList<OCACExamCandidate> procOCACExamCandidates = await _procedureAdabter
               .Execute<OCACExamCandidate>("[OCAC].[proc_OCAC_Exam__CandidateLoadByPrimaryKey_OCAC_Exam_Plan_ID]", request);
            GetprocOCACExamCandidateLoadAllListVm vm = new GetprocOCACExamCandidateLoadAllListVm
            {
                procOCACExamCandidates = _mapper.Map<IList<OCACExamCandidate>, IList<GetprocOCACExamCandidateLoadAllVm>>(procOCACExamCandidates)
            };

            return vm;
        }
    }
}
