

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.OCAC;
using XOKA.Domain.Interfaces;

namespace Application.OCAC.Commands.procCoCApplayExamFor.procCoCApplayExamForUpdate.procCoCApplayExamForUpdateCommand
{

    /// @author  Shimels Alem  proc_CoCApplay_Exam_ForUpdate stored procedure.


    public class procCoCApplayExamForUpdateHandler : IRequestHandler<procCoCApplayExamForUpdateCommand, IList<CoCApplayExamFor_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procCoCApplayExamForUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CoCApplayExamFor_Id>> Handle( procCoCApplayExamForUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<CoCApplayExamFor_Id> result = await _procedureAdabter
                .Execute<CoCApplayExamFor_Id>("[OCAC].proc_CoCApplay_Exam_ForUpdate", request);
           

            return result;
        }
    }
}
 