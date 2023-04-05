 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Trade;

namespace Application.Trade.Commands.procCompanyDetailAM.procCompanyDetailAMDelete.procCompanyDetailAMDeleteCommand
{

    // @author  Shimels Alem  proc_Company_Detail_AMDelete stored procedure.

    public class procCompanyDetailAMDeleteCommand : IRequest<IList<CompanyDetailAM_ID>>
    {
        public System.Guid ID { get; set; }
    }
		
     
		
		 
}
 
 