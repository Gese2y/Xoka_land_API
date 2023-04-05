using AutoMapper;
using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.WorkSpace;

namespace Application.WorkSpace.Commands.procEnterpriseWorkSpaceRent.procEnterpriseWorkSpaceRentUpdate.procEnterpriseWorkSpaceRentUpdateCommand
{

    /// @author  Shimels Alem  proc_Enterprise_Work_Space_RentUpdate stored procedure.

    public class procEnterpriseWorkSpaceRentUpdateCommand : IRequest<IList<EnterpriseWorkSpaceRent_WorkSpaceIDAndTIN>>
   {
        public System.Guid Work_Space_ID { get; set; }
        public string TIN { get; set; }
        public System.Guid? EAFW_ID { get; set; }
        public System.DateTime? Start_Date { get; set; }
        public System.DateTime? End_Date { get; set; }
        public byte[] Contract_Doc { get; set; }
        public string EWSR_Status { get; set; }
        public bool? Is_Active { get; set; }
        public System.Guid? Parent { get; set; }
        public System.Double? Monthly_Price { get; set; }
    }
		
		
		 
}

