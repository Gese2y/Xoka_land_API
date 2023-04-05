using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procMarketOPP.procMarketOPPUpdate.procMarketOPPUpdateCommand
{

	/// @author  Shimels Alem  proc_Market_OPPUpdate stored procedure.

	public class procMarketOPPUpdateCommand : IRequest<IList<MarketOPP_OPPID>>
   {
        public System.Guid OPP_ID { get; set; }
        public string TIN { get; set; }
        public string Opp_Type { get; set; }
        public Nullable<System.Guid> Region { get; set; }
        public Nullable<System.Guid> Zone { get; set; }
        public Nullable<System.Guid> Woreda { get; set; }
        public string Hous_No { get; set; }
        public Nullable<int> JobOpen_For_ENT { get; set; }
        public Nullable<int> Job_Open_For_Job_Seeker { get; set; }
        public Nullable<System.Guid> Licence_ID { get; set; }
        public Nullable<System.DateTime> Registered_Date { get; set; }
    }
		
		
		 
}

