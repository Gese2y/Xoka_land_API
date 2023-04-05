using Application.Common.Mappings;
using AutoMapper;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Trade;

namespace Application.Trade.Quiries.procRenewInfoChange
{
    public class GetprocRenewInfoChangeLoadAllVm : IMapFrom<RenewInfoChange>
    {
		public System.Guid Change_ID { get; set; }
		public string ID { get; set; }
		public string Issue_Type { get; set; }
		public string Issue_Reason { get; set; }
		public string FName { get; set; }
		public string MName { get; set; }
		public string LName { get; set; }
		public System.DateTime? Date_Issued { get; set; }
		public System.DateTime? Exp_Date { get; set; }
		public string Region { get; set; }
		public string Zone_SubCity { get; set; }
		public string Woreda_Kebele { get; set; }
		public string House_NO { get; set; }
		public string Phone { get; set; }
		public string Emergency_Contact_Name { get; set; }
		public string Emergency_Contact_Phone { get; set; }
		public byte[] Photo { get; set; }
		public byte[] Finger { get; set; }
		public bool? Is_Active { get; set; }
		public System.Guid? Regstered_Org { get; set; }
		public System.Guid? User_ID { get; set; }
		public System.DateTime? created_date { get; set; }
		public System.DateTime? Updated_date { get; set; }
		public System.Guid? Updated_By_user { get; set; }
		public System.Guid? Parent { get; set; }
		public void Mapping(Profile profile)
        {
            profile.CreateMap<RenewInfoChange, GetprocRenewInfoChangeLoadAllVm>();
        }
    }
}
