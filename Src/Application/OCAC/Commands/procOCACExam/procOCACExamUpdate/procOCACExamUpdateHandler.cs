

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.OCAC;
using XOKA.Domain.Interfaces;

namespace Application.OCAC.Commands.procOCACExam.procOCACExamUpdate.procOCACExamUpdateCommand
{

    /// @author  Shimels Alem  proc_OCAC_ExamUpdate stored procedure.


    public class procOCACExamUpdateHandler : IRequestHandler<procOCACExamUpdateCommand, IList<OCACExam_ExamID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procOCACExamUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<OCACExam_ExamID>> Handle( procOCACExamUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<OCACExam_ExamID> result = await _procedureAdabter
                .Execute<OCACExam_ExamID>("[OCAC].proc_OCAC_ExamUpdate", request);
           

            return result;
        }
    }
}
 