



using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.OCAC;
using XOKA.Domain.Interfaces;


namespace Application.OCAC.Commands.procCoCApplayExamFor.procCoCApplayExamForInsert.procCoCApplayExamForInsertCommand
{

    /// @author  Shimels Alem  proc_CoCApplay_Exam_ForInsert stored procedure.


    public class procCoCApplayExamForInsertHandler : IRequestHandler<procCoCApplayExamForInsertCommand, IList<CoCApplayExamFor_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procCoCApplayExamForInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CoCApplayExamFor_Id>> Handle( procCoCApplayExamForInsertCommand request, CancellationToken cancellationToken)
        {

            IList<CoCApplayExamFor_Id> result = await _procedureAdabter
                .Execute<CoCApplayExamFor_Id>("[OCAC].proc_CoCApplay_Exam_ForInsert", request);
           

            return result;
        }
    }
}
 