 


using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Commands.procSchedule.procScheduleDelete.procScheduleDeleteCommand
{

    // @author  Shimels Alem  proc_ScheduleDelete stored procedure.

    public class procScheduleDeleteCommand : IRequest<IList<Schedule_SID>>
    {
        public System.Guid SID { get; set; }
    }
		
     
		
		 
}
 
 