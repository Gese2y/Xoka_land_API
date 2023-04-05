


using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.Trade;

namespace Application.Trade.Commands.procCapital.procCapitalInsert.procCapitalInsertCommand
{

    /// @author  Shimels Alem  proc_CapitalInsert stored procedure.


    public class procCapitalInsertCommand : IRequest<IList<Capital_CapitalID>>
    {
        public System.Guid Capital_ID { get; set; }
        public string COM_REG_Number { get; set; }
        public System.Double Intaial_Capital { get; set; }
        public System.Double? Current_Capital { get; set; }
        public string Year { get; set; }
        public System.DateTime? Updated_Date { get; set; }
        public bool? Is_Active { get; set; }
    }
		
		
		 
}
 
 