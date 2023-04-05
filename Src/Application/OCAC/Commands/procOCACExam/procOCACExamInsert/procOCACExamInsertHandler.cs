



using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.OCAC;
using XOKA.Domain.Interfaces;


namespace Application.OCAC.Commands.procOCACExam.procOCACExamInsert.procOCACExamInsertCommand
{

    /// @author  Shimels Alem  proc_OCAC_ExamInsert stored procedure.


    public class procOCACExamInsertHandler : IRequestHandler<procOCACExamInsertCommand, IList<OCACExam_ExamID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procOCACExamInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<OCACExam_ExamID>> Handle( procOCACExamInsertCommand request, CancellationToken cancellationToken)
        {

            IList<OCACExam_ExamID> result = await _procedureAdabter
                .Execute<OCACExam_ExamID>("[OCAC].proc_OCAC_ExamInsert", request);
           

            return result;
        }
    }
}
 