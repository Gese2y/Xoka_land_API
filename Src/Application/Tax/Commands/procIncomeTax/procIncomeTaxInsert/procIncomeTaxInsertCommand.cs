


using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.Tax;

namespace Application.Tax.Commands.procIncomeTax.procIncomeTaxInsert.procIncomeTaxInsertCommand
{

    /// @author  Shimels Alem  proc_Income_TaxInsert stored procedure.


    public class procIncomeTaxInsertCommand : IRequest<IList<IncomeTax_ID>>
    {
        public System.Guid ID { get; set; }
        public System.Guid TIN { get; set; }
        public System.DateTime Year { get; set; }
        public System.DateTime? Date_Paid { get; set; }
        public string Type_Income_Tax { get; set; }
        public int? Amount { get; set; }
    }
		
		
		 
}
 
 