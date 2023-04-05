


using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.dbo;

namespace Application.dbo.Commands.procLicenceServiceForSingleWin.procLicenceServiceForSingleWinInsert.procLicenceServiceForSingleWinInsertCommand
{

	/// @author  Shimels Alem  proc_Licence_Service_For_Single_WinInsert stored procedure.


	public class procLicenceServiceForSingleWinInsertCommand : IRequest<IList<LicenceServiceForSingleWin_LicenceId>>
    {
		public System.Guid Licence_Id { get; set; }
		public string Customer_code { get; set; }
		public string Customer_Name { get; set; }
		public string Customer_Phone { get; set; }
		public string UnEmploued_ID { get; set; }
		public string ID_No { get; set; }
		public string TIN { get; set; }
		public string VAT { get; set; }
		public string MSE_Cdoe { get; set; }
		public string DAR_NO { get; set; }
		public string CU_NO { get; set; }
		public string AC_No { get; set; }
	}
		
		
		 
}
 
 