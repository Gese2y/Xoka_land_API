using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Spatial;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procBazarAndExhibition.procBazarAndExhibitionUpdate.procBazarAndExhibitionUpdateCommand
{

	/// @author  Shimels Alem  proc_Bazar&ExhibitionUpdate stored procedure.

	public class procBazarAndExhibitionUpdateCommand : IRequest<IList<BazarAndExhibition_ID>>
   {
		public System.Guid ID { get; set; }
		public System.Guid? OPP_ID { get; set; }
		public System.DateTime? date { get; set; }
		public string Address { get; set; }
		public System.Int32? Number_Particpants { get; set; }
		public System.Int32? Expected_Visters { get; set; }
		public System.Double? Entrance_fee { get; set; }
		public System.Double? Partcipation_fee { get; set; }
		public string Remark { get; set; }
		public string Location_X { get; set; }
		public string location_Y { get; set; }
	}
		
		
		 
}

