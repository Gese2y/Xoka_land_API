using AutoMapper;
using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.TVET;

namespace Application.TVET.Commands.procApproved_For_Training.Update.procApproved_For_TrainingUpdateCommand
{

    /// @author  Shimels Alem  proc_AttendanceUpdate stored procedure.

    public class procApproved_For_TrainingUpdateCommand : IRequest<IList<Approved_For_TrainingID>>
   {
		public System.Guid ID { get; set; }
		public string Vital_ID { get; set; }
		public bool? Approved_for_Training { get; set; }
		public System.DateTime? Date_Applyed { get; set; }
		public System.DateTime? End_Date { get; set; }
		public System.Guid? Approved_By { get; set; }

	}



}

