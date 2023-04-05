


using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.Trade;

namespace Application.Trade.Commands.procProduct.procProductInsert.procProductInsertCommand
{

	/// @author  Shimels Alem  proc_ProductInsert stored procedure.


	public class procProductInsertCommand : IRequest<IList<Product_ID>>
    {
		public System.Guid ID { get; set; }
		public string Code { get; set; }
		public string Name { get; set; }
		public string Sector { get; set; }
		public string Sub_Sector { get; set; }
		public System.Guid? Parent { get; set; }
		public bool? IS_Active { get; set; }
	}
		
		
		 
}
 
 