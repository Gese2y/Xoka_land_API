using AutoMapper;
using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.Trade;

namespace Application.Trade.Commands.procCapital.procCapitalUpdate.procCapitalUpdateCommand
{

    /// @author  Shimels Alem  proc_CapitalUpdate stored procedure.

    public class procCapitalUpdateCommand : IRequest<IList<Capital_CapitalID>>
   {
        public System.Guid Capital_ID { get; set; }
        public string COM_REG_Number { get; set; }
        public System.Double Intaial_Capital { get; set; }
        public System.Double? Current_Capital { get; set; }
        public string Year { get; set; }
        public System.DateTime? Updated_Date { get; set; }
        public bool? Is_Active { get; set; }
    }
		
		
		 
}

