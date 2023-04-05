using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.OCAC;
using XOKA.Domain.Interfaces;

namespace Application.OCAC.Commands.procStandardExamReq.procStandardExamReqDelete.procStandardExamReqDeleteCommand
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
                .Execute<StandardExamReq_OSIDAndOCACExam>("[OCAC].proc_Standard_Exam_ReqDelete", request);
           

            return result;
        }
    }
}
  