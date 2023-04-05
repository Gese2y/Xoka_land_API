using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.OCAC;
using XOKA.Domain.Interfaces;

namespace Application.OCAC.Commands.procCoCApplayExamFor.procCoCApplayExamForDelete.procCoCApplayExamForDeleteCommand
{

    /// @author  Shimels Alem  proc_CoCApplay_Exam_ForDelete stored procedure.


    public class procCoCApplayExamForDeleteHandler : IRequestHandler<procCoCApplayExamForDeleteCommand, IList<CoCApplayExamFor_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procCoCApplayExamForDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CoCApplayExamFor_Id>> Handle( procCoCApplayExamForDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<CoCApplayExamFor_Id> result = await _procedureAdabter
                .Execute<CoCApplayExamFor_Id>("[OCAC].proc_CoCApplay_Exam_ForDelete", request);
           

            return result;
        }
    }
}
  