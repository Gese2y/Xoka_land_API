using AutoMapper;
using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.Trade;

namespace Application.Trade.Commands.procCompanyDetailAM.procCompanyDetailAMUpdate.procCompanyDetailAMUpdateCommand
{

	/// @author  Shimels Alem  proc_Company_Detail_AMUpdate stored procedure.

	public class procCompanyDetailAMUpdateCommand : IRequest<IList<CompanyDetailAM_ID>>
   {
		public System.Guid ID { get; set; }
		public string COM_REG_Number { get; set; }
		public string Nationality { get; set; }
		public string GM_User { get; set; }
		public string Region { get; set; }
		public string Zone { get; set; }
		public string City { get; set; }
		public string Sub_City { get; set; }
		public string Woreda { get; set; }
		public string House_Number { get; set; }
		public string Email { get; set; }
		public bool? Is_Active { get; set; }
	}
		
		
		 
}

