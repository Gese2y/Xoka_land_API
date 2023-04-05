


using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.Tax;

namespace Application.Tax.Commands.procTIN.procTINInsert.procTINInsertCommand
{

	/// @author  Shimels Alem  proc_TINInsert stored procedure.


	public class procTINInsertCommand : IRequest<IList<TIN_ID>>
    {
		public System.Guid ID { get; set; }
		public string TIN { get; set; }
		public System.DateTime? Date_Issued { get; set; }
		public string Certificate_Code { get; set; }
		public string Certificate_NO { get; set; }
		public string Remark { get; set; }
		public bool? IsActive { get; set; }
		public System.Guid? Created_By { get; set; }
		public System.Guid? Updated_By { get; set; }
		public byte[] Date_log { get; set; }
	}
		
		
		 
}
 
 