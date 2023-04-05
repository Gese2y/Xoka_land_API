



using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.OCAC;
using XOKA.Domain.Interfaces;


namespace Application.OCAC.Commands.procCOCCandidate.procCOCCandidateInsert.procCOCCandidateInsertCommand
{

    /// @author  Shimels Alem  proc_COC_CandidateInsert stored procedure.


    public class procCOCCandidateInsertHandler : IRequestHandler<procCOCCandidateInsertCommand, IList<COCCandidate_COCCandID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procCOCCandidateInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<COCCandidate_COCCandID>> Handle( procCOCCandidateInsertCommand request, CancellationToken cancellationToken)
        {

            IList<COCCandidate_COCCandID> result = await _procedureAdabter
                .Execute<COCCandidate_COCCandID>("[OCAC].proc_COC_CandidateInsert", request);
           

            return result;
        }
    }
}
 