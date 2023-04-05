

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.TVET;
using XOKA.Domain.Interfaces;

namespace Application.TVET.Commands.procStandardExamReq.procStandardExamReqUpdate.procStandardExamReqUpdateCommand
{ 
	 
	/// @author  Shimels Alem  [sp not found] stored procedure.
	 
	 
      public class procStandardExamReqUpdateHandler : IRequestHandler<procStandardExamReqUpdateCommand, IList<StandardExamReq_OSIDAndOCACExam>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procStandardExamReqUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<StandardExamReq_OSIDAndOCACExam>> Handle( procStandardExamReqUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<StandardExamReq_OSIDAndOCACExam> result = await _procedureAdabter
                .Execute<StandardExamReq_OSIDAndOCACExam>("[TVET].[sp not found]", request);
           

            return result;
        }
    }
}
 