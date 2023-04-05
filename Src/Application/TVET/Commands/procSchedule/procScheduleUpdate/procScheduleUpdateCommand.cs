using AutoMapper;
using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.TVET;

namespace Application.TVET.Commands.procSchedule.procScheduleUpdate.procScheduleUpdateCommand
{

    /// @author  Shimels Alem  proc_ScheduleUpdate stored procedure.

    public class procScheduleUpdateCommand : IRequest<IList<Schedule_SID>>
   {
        public System.Guid SID { get; set; }
        public System.Guid? EID { get; set; }
        public System.DateTime? Start_Date { get; set; }
        public System.DateTime? End_Date { get; set; }
        public System.TimeSpan? Start_Hour { get; set; }
        public System.TimeSpan? End_Hour { get; set; }
        public string Course_Code { get; set; }
        public System.Guid? Instructor_ID { get; set; }
        public string Venue { get; set; }
    }
		
		
		 
}

