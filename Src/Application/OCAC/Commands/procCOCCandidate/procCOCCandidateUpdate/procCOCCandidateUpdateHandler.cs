

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.OCAC;
using XOKA.Domain.Interfaces;

namespace Application.OCAC.Commands.procCOCCandidate.procCOCCandidateUpdate.procCOCCandidateUpdateCommand
{

    /// @author  Shimels Alem  proc_COC_CandidateUpdate stored procedure.


    public class procCOCCandidateUpdateHandler : IRequestHandler<procCOCCandidateUpdateCommand, IList<COCCandidate_COCCandID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procCOCCandidateUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<COCCandidate_COCCandID>> Handle( procCOCCandidateUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<COCCandidate_COCCandID> result = await _procedureAdabter
                .Execute<COCCandidate_COCCandID>("[OCAC].proc_COC_CandidateUpdate", request);
           

            return result;
        }
    }
}
 