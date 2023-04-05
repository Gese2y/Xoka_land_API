using AutoMapper;
using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.Trade;

namespace Application.Trade.Commands.procBusinessCode.procBusinessCodeUpdate.procBusinessCodeUpdateCommand
{

    /// @author  Shimels Alem  proc_Business_CodeUpdate stored procedure.

    public class procBusinessCodeUpdateCommand : IRequest<IList<BusinessCode_Code>>
   {
        public string Code { get; set; }
        public string Name_AM { get; set; }
        public string Name_EN { get; set; }
        public string Parent { get; set; }
        public bool? Is_Sector { get; set; }
    }
		
		
		 
}

