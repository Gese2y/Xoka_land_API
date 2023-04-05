


using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.WorkSpace;

namespace Application.WorkSpace.Commands.procLocationforBusOPP.procLocationforBusOPPInsert.procLocationforBusOPPInsertCommand
{

    /// @author  Shimels Alem  proc_Location_for_Bus_OPPInsert stored procedure.


    public class procLocationforBusOPPInsertCommand : IRequest<IList<LocationforBusOPP_BUSOPPLocCode>>
    {
        public System.Guid BUS_OPP_Loc_Code { get; set; }
        public System.Guid BUS_OPP_ID { get; set; }
        public string Region { get; set; }
        public string Zone { get; set; }
        public string Woreda { get; set; }
        public int JobOpen_For_ENT { get; set; }
        public int Job_Open_For_Job_Seeker { get; set; }
        public string Remark { get; set; }
    }
		
		
		 
}
 
 