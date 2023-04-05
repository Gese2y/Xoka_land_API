


using MediatR;
using System;
using System.Collections.Generic;
using System.Spatial;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Commands.procBazarAndExhibition.procBazarAndExhibitionInsert.procBazarAndExhibitionInsertCommand
{

	/// @author  Shimels Alem  proc_Bazar&ExhibitionInsert stored procedure.


	public class procBazarAndExhibitionInsertCommand : IRequest<IList<BazarAndExhibition_ID>>
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
 
 