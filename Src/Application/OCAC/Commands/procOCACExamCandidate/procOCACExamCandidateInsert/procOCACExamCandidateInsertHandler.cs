



using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.OCAC;
using XOKA.Domain.Interfaces;


namespace Application.OCAC.Commands.procOCACExamCandidate.procOCACExamCandidateInsert.procOCACExamCandidateInsertCommand
{

    /// @author  Shimels Alem  proc_OCAC_Exam__CandidateInsert stored procedure.


    public class procOCACExamCandidateInsertHandler : IRequestHandler<procOCACExamCandidateInsertCommand, IList<OCACExamCandidate_OCACCandiate>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procOCACExamCandidateInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<OCACExamCandidate_OCACCandiate>> Handle( procOCACExamCandidateInsertCommand request, CancellationToken cancellationToken)
        {

            System.Guid OCAC_Candiate = request.OCAC_Candiate;
            System.Guid? OCAC_Exam_Plan_ID = request.OCAC_Exam_Plan_ID;
            System.Guid? Cand_ID = request.Cand_ID;
            byte[]? IS_Approved = request.IS_Approved;
            string IS_Present = request.IS_Present;
            string Remark = request.Remark;
            string Student = request.Student;
            IList<OCACExamCandidate_OCACCandiate> result = await _procedureAdabter
                    .Execute<OCACExamCandidate_OCACCandiate>("[OCAC].proc_OCAC_Exam__CandidateInsert",
                    (nameof(OCAC_Candiate), OCAC_Candiate),
                    (nameof(OCAC_Exam_Plan_ID), OCAC_Exam_Plan_ID),
                    (nameof(Cand_ID), Cand_ID),
                    (nameof(IS_Approved), IS_Approved),
                    (nameof(IS_Present), IS_Present),
                    (nameof(Remark), Remark),
                    (nameof(Student), Student)
                    );
           

            return result;
        }
    }
}
 