using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.OCAC;
using XOKA.Domain.Interfaces;

namespace Application.OCAC.Commands.procCOCCandidate.procCOCCandidateDelete.procCOCCandidateDeleteCommand
{

    /// @author  Shimels Alem  proc_COC_CandidateDelete stored procedure.


    public class procCOCCandidateDeleteHandler : IRequestHandler<procCOCCandidateDeleteCommand, IList<COCCandidate_COCCandID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procCOCCandidateDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<COCCandidate_COCCandID>> Handle( procCOCCandidateDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<COCCandidate_COCCandID> result = await _procedureAdabter
                .Execute<COCCandidate_COCCandID>("[OCAC].proc_COC_CandidateDelete", request);
           

            return result;
        }
    }
}
  