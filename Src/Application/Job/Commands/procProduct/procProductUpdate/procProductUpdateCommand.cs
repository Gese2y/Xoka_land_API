using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procProduct.procProductUpdate.procProductUpdateCommand
{

	/// @author  Shimels Alem  proc_ProductUpdate stored procedure.

	public class procProductUpdateCommand : IRequest<IList<Product_ID>>
   {
        public System.Guid ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Sector { get; set; }
        public string Sub_Sector { get; set; }
        public System.Guid? Parent { get; set; }
        public bool? IS_Active { get; set; }
    }
		
		
		 
}

