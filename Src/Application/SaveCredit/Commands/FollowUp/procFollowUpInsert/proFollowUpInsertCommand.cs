
using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.SaveCredit;

namespace Application.SaveCredit.Commands.FollowUp.procFollowUpInsert.proFollowUpInsertCommand
{
    public class proFollowUpInsertCommand : IRequest<IList<FollowUp_ID>>
    {
        public System.Guid FollowID { get; set; }
        public System.Guid UserID { get; set; }
        public System.DateTime? Date { get; set; }
        public string FollowUpBy { get; set; }
        public string ContactNumber { get; set; }
    }
}
