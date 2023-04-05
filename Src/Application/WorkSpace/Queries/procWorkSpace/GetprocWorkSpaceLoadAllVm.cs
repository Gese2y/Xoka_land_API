using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Spatial;
using System.Text;
using XOKA.Domain.Entities.WorkSpace;

namespace Application.WorkSpace.Quiries.procWorkSpace
{
    public class GetprocWorkSpaceLoadAllVm : IMapFrom<_WorkSpace>
    {
		public System.Guid Work_Space_ID { get; set; }
		public string Code { get; set; }
		public string Work_Space_Type { get; set; }
		public string Work_Space_Status { get; set; }
		public System.Guid Region { get; set; }
		public System.Guid Zone { get; set; }
		public System.Guid Woreda { get; set; }
		public string Hous_No { get; set; }
		public System.Guid? Owner_Org { get; set; }
		public string Location { get; set; }
		public string Location_Name { get; set; }
		public string Location_x { get; set; }
		public string Location_y { get; set; }
		public System.Double? RentPrice_Per_Month_Birr { get; set; }
		public System.Double? Size_M2 { get; set; }
		public string Grade { get; set; }
		public string Remark { get; set; }
		public bool? Is_Built_By_Private { get; set; }

		public bool? Is_Built_By_Government { get; set; }
		public bool? Is_Built_By_NGO { get; set; }
		public void Mapping(Profile profile)
        {
            profile.CreateMap<_WorkSpace, GetprocWorkSpaceLoadAllVm>();
        }
    }
}
