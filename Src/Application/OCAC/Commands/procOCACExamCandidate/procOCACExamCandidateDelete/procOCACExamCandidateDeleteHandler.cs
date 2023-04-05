using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.OCAC;
using XOKA.Domain.Interfaces;

namespace Application.OCAC.Commands.procOCACExamCandidate.procOCACExamCandidateDelete.procOCACExamCandidateDeleteCommand
{

    /// @author  Shimels Alem  proc_OCAC_Exam__CandidateDelete stored procedure.


    public class procOCACExamCandidateDeleteHandler : IRequestHandler<procOCACExamCandidateDeleteCommand, IList<OCACExamCandidate_OCACCandiate>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procOCACExamCandidateDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<OCACExamCandidate_OCACCandiate>> Handle( procOCACExamCandidateDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<OCACExamCandidate_OCACCandiate> result = await _procedureAdabter
                .Execute<OCACExamCandidate_OCACCandiate>("[OCAC].proc_OCAC_Exam__CandidateDelete", request);
           

            return result;
        }
    }
}
  