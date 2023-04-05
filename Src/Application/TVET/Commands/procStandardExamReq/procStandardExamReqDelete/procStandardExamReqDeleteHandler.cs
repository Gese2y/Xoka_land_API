using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.TVET;
using XOKA.Domain.Interfaces;

namespace Application.TVET.Commands.procStandardExamReq.procStandardExamReqDelete.procStandardExamReqDeleteCommand
{

    /// @author  Shimels Alem  proc_Standard_Exam_ReqDelete stored procedure.


    public class procStandardExamReqDeleteHandler : IRequestHandler<procStandardExamReqDeleteCommand, IList<StandardExamReq_OSIDAndOCACExam>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procStandardExamReqDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<StandardExamReq_OSIDAndOCACExam>> Handle( procStandardExamReqDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<StandardExamReq_OSIDAndOCACExam> result = await _procedureAdabter
                .Execute<StandardExamReq_OSIDAndOCACExam>("[TVET].proc_Standard_Exam_ReqDelete", request);
           

            return result;
        }
    }
}
  