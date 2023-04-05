using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procbussinessRelationMKT.procbussinessRelationMKTUpdate.procbussinessRelationMKTUpdateCommand
{

	/// @author  Shimels Alem  proc_bussiness_Relation_MKTUpdate stored procedure.

	public class procbussinessRelationMKTUpdateCommand : IRequest<IList<bussinessRelationMKT_ID>>
   {
		public System.Guid ID { get; set; }
		public System.Guid? Supplier { get; set; }
		public System.Guid? Buyer_ID { get; set; }
		public byte[]? Contract_DOC { get; set; }
		public System.DateTime? Date { get; set; }
		public System.Double? Amount_Contract_Birr { get; set; }
		public System.DateTime? Expire_Date { get; set; }
		public bool? Is_Active { get; set; }
		public string Remark { get; set; }
		public System.Guid? Created_By { get; set; }
		public System.Guid? Updated_By { get; set; }
		public System.DateTime Updated_Date { get; set; }
	}
		
		
		 
}

