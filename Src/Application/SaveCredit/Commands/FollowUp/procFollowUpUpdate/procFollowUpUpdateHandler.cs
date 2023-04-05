
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.SaveCredit;
using XOKA.Domain.Interfaces;

namespace Application.SaveCredit.Commands.FollowUp.procFollowUpUpdate.procFollowUpUpdateCommand
{
    public class procFollowUpUpdateHandler : IRequestHandler<procFollowUpUpdateCommand, IList<FollowUp_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procFollowUpUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<FollowUp_ID>> Handle(procFollowUpUpdateCommand request, CancellationToken cancellationToken)
        {
            System.Guid FollowID = request.FollowID;
            System.Guid UserID = request.UserID;
            System.DateTime? Date = request.Date;
            string FollowUpBy = request.FollowUpBy;
            string ContactNumber = request.ContactNumber;
            IList<FollowUp_ID> result = await _procedureAdabter.Execute<FollowUp_ID>("[Job].proc_tblFollowUpUpdate",
                (nameof(FollowID), FollowID),
                    (nameof(UserID), UserID),
                    (nameof(Date), Date),
                    (nameof(FollowUpBy), FollowUpBy),
                    (nameof(ContactNumber), ContactNumber)
                    );

            return result;
        }

    }
}
