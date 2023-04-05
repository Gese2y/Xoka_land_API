using AutoMapper;
using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.SaveCredit;

namespace Application.SaveCredit.Commands.procApplicationForCreadit.procApplicationForCreaditUpdate.procApplicationForCreaditUpdateCommand
{

    /// @author  Shimels Alem  proc_Application_For_CreaditUpdate stored procedure.

    public class procApplicationForCreaditUpdateCommand : IRequest<IList<ApplicationForCreadit_ID>>
   {
        public System.Guid ID { get; set; }
        public long? TIN { get; set; }
        public string Application { get; set; }
        public System.Double? Amount { get; set; }
        public System.Guid? Doc_ID { get; set; }
        public bool? IS_Disprove { get; set; }
    }
		
		
		 
}

