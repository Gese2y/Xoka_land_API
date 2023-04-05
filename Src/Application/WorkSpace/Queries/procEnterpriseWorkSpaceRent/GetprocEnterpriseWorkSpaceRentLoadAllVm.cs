using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.WorkSpace;

namespace Application.WorkSpace.Quiries.procEnterpriseWorkSpaceRent
{
    public class GetprocEnterpriseWorkSpaceRentLoadAllVm : IMapFrom<EnterpriseWorkSpaceRent>
    {
		public System.Guid Work_Space_ID { get; set; }
		public string TIN { get; set; }
		public System.Guid? EAFW_ID { get; set; }
		public System.Double? Monthly_Price { get; set; }
		public System.DateTime? Start_Date { get; set; }
		public System.DateTime? End_Date { get; set; }
		public byte[] Contract_Doc { get; set; }
		public string EWSR_Status { get; set; }
		public bool? Is_Active { get; set; }
		public System.Guid? Parent { get; set; }

		public void Mapping(Profile profile)
        {
            profile.CreateMap<EnterpriseWorkSpaceRent, GetprocEnterpriseWorkSpaceRentLoadAllVm>();
        }
    }
}
