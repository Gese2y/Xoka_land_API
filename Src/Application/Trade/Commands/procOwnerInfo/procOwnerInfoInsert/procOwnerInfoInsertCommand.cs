


using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.Trade;

namespace Application.Trade.Commands.procOwnerInfo.procOwnerInfoInsert.procOwnerInfoInsertCommand
{

	/// @author  Shimels Alem  proc_Owner_InfoInsert stored procedure.


	public class procOwnerInfoInsertCommand : IRequest<IList<OwnerInfo_ID>>
    {
		public System.Guid ID { get; set; }
		public string Position { get; set; }
		public string Full_Name { get; set; }
		public bool? IsActive { get; set; }
		public bool? IS_GM { get; set; }
		public System.DateTime? Registration_Date { get; set; }
		public byte[] Photo { get; set; }
		public string Company_TIn_NO { get; set; }
		public int? NO_Of_Share { get; set; }
		public int? Share_Price { get; set; }
		public bool? IS_Current { get; set; }
		public System.DateTime? YEAR { get; set; }
		public System.Guid? Parent { get; set; }
	}
		
		
		 
}
 
 