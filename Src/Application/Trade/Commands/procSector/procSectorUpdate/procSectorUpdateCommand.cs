using AutoMapper;
using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.Trade;

namespace Application.Trade.Commands.procSector.procSectorUpdate.procSectorUpdateCommand
{

	/// @author  Shimels Alem  proc_Business_ActivityUpdate stored procedure.

	public class procSectorUpdateCommand : IRequest<IList<Sector_Code>>
   {
		public string S_Code { get; set; }
		public string Name_AM { get; set; }
		public string Name_EN { get; set; }
		public string Parent { get; set; }
		public string Comm_Bus_Code { get; set; }
	}
		
		
		 
}

