


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Commands.procBussRelationInput.procBussRelationInputInsert.procBussRelationInputInsertCommand
{

	/// @author  Shimels Alem  proc_Buss_Relation_InputInsert stored procedure.


	public class procBussRelationInputInsertCommand : IRequest<IList<BussRelationInput_ID>>
    {
		public System.Guid ID { get; set; }
		public System.Guid? Buyer_ID { get; set; }
		public System.Guid? Supplier { get; set; }
		public byte[] Contract_DOC { get; set; }
		public System.DateTime? Date { get; set; }
		public System.Double? Amount_Contract_Birr { get; set; }
		public System.DateTime? Expire_Date { get; set; }
		public bool? Is_Active { get; set; }
		public string Remark { get; set; }
		public System.Guid? Created_By { get; set; }
		public System.Guid? Updated_By { get; set; }
		public System.DateTime? Updated_Date { get; set; }
	}
		
		
		 
}
 
 