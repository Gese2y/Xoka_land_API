


using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.Trade;

namespace Application.Trade.Commands.procBusinessActivity.procBusinessActivityInsert.procBusinessActivityInsertCommand
{

    /// @author  Shimels Alem  proc_Business_ActivityInsert stored procedure.


    public class procBusinessActivityInsertCommand : IRequest<IList<BusinessActivity_Code>>
    {
        public string Code { get; set; }
        public string TIN { get; set; }
        public string Bus_Activity_code { get; set; }
        public string Activity_Name { get; set; }
    }
		
		
		 
}
 
 