using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Quiries.procBussRelationInput
{
    public class GetprocBussRelationInputLoadAllVm : IMapFrom<BussRelationInput>
    {
		public System.Guid ID { get; set; }
		public System.Guid? Buyer_ID { get; set; }
		public System.Guid? Supplier { get; set; }
		public byte[] Contract_DOC { get; set; }
		public System.DateTime? Date { get; set; }
		public System.Double? Amount_Contract_Birr { get; set; }
		public System.DateTime? Expire_Date { get; set; }
		public bool? Is_Active { get; set; }
		public string Remark { get; set; }
		public System.Guid? Created_By { get; set; }
		public System.Guid? Updated_By { get; set; }
		public System.DateTime? Updated_Date { get; set; }
		public void Mapping(Profile profile)
        {
            profile.CreateMap<BussRelationInput, GetprocBussRelationInputLoadAllVm>();
        }
    }
}
