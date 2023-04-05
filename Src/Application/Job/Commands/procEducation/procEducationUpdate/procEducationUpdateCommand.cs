using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procEducation.procEducationUpdate.procEducationUpdateCommand
{

	/// @author  Shimels Alem  proc_EducationUpdate stored procedure.

	public class procEducationUpdateCommand : IRequest<IList<Education_ID>>
   {
        public System.Guid ID { get; set; }
        public string EMP_TIN { get; set; }
        public string Level { get; set; }
        public string Instiutution { get; set; }
        public System.DateTime? Graduate_Date { get; set; }
        public System.Guid? Doc_ID { get; set; }
        public System.Guid? Created_By { get; set; }
        public System.Guid? Updated_By { get; set; }
        public System.Byte[]? Date_log { get; set; }
        public string Eduction_Types { get; set; }
    }
		
		
		 
}

