 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Trade;

namespace Application.Trade.Commands.procCompanyDetailEN.procCompanyDetailENDelete.procCompanyDetailENDeleteCommand
{

    // @author  Shimels Alem  proc_Company_Detail_ENDelete stored procedure.

    public class procCompanyDetailENDeleteCommand : IRequest<IList<CompanyDetailEN_ID>>
    {
        public System.Guid ID { get; set; }
    }
		
     
		
		 
}
 
 