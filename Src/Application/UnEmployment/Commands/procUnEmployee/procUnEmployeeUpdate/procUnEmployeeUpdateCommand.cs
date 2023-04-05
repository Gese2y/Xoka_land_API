﻿using AutoMapper;
using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.UnEmployment;

namespace Application.UnEmployment.Commands.procUnEmployee.procUnEmployeeUpdate.procUnEmployeeUpdateCommand
{

    /// @author  Shimels Alem  proc_UnEmployeeUpdate stored procedure.

    public class procUnEmployeeUpdateCommand : IRequest<IList<UnEmployee_TIN>>
   {
        public string Vital_ID { get; set; }
        public string TIN { get; set; }
        public string Full_Name { get; set; }
        public string Status { get; set; }
        public byte[] Photo { get; set; }
        public System.Guid? Created_By { get; set; }
        public System.Guid? Updated_By { get; set; }
        public byte[] Date_log { get; set; }
        public System.Guid? UnEmployeeRequest_ID { get; set; }
        public string Unemployment_Number { get; set; }
        public System.DateTime? Date_Issued { get; set; }
        public string Physical_Condition { get; set; }
        public string Refugee_Status { get; set; }
        public string HIV_Status { get; set; }
        public string Returnee_Status { get; set; }
        public string Gender { get; set; }
    }
		
		
		 
}

