



using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.OCAC;
using XOKA.Domain.Interfaces;


namespace Application.OCAC.Commands.procStandardExamReq.procStandardExamReqInsert.procStandardExamReqInsertCommand
{

    /// @author  Shimels Alem  proc_Standard_Exam_ReqInsert stored procedure.


    public class procStandardExamReqInsertHandler : IRequestHandler<procStandardExamReqInsertCommand, IList<StandardExamReq_OSIDAndOCACExam>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procStandardExamReqInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<StandardExamReq_OSIDAndOCACExam>> Handle( procStandardExamReqInsertCommand request, CancellationToken cancellationToken)
        {

            IList<StandardExamReq_OSIDAndOCACExam> result = await _procedureAdabter
                .Execute<StandardExamReq_OSIDAndOCACExam>("[OCAC].proc_Standard_Exam_ReqInsert", request);
           

            return result;
        }
    }
}
 