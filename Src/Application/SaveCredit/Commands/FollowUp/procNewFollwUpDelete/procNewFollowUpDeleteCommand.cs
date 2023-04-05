using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.SaveCredit;

namespace Application.SaveCredit.Commands.FollowUp.procNewFollwUpDelete.procNewFollowUpDeleteCommand
{
    public class procNewFollowUpDeleteCommand : IRequest<IList<FollowUp_ID>>
    {
        public System.Guid FollowID { get; set; }
    }
}
