using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.SaveCredit;
using XOKA.Domain.Interfaces;

namespace Application.SaveCredit.Commands.FollowUp.procNewFollwUpDelete.procNewFollowUpDeleteCommand
{
    public class proNewFollowUpDeleteHandler : IRequestHandler<procNewFollowUpDeleteCommand, IList<FollowUp_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proNewFollowUpDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<FollowUp_ID>> Handle(procNewFollowUpDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<FollowUp_ID> result = await _procedureAdabter
                .Execute<FollowUp_ID>("[Job].proc_tblFollowUpDelete", request);


            return result;
        }
    }
}
