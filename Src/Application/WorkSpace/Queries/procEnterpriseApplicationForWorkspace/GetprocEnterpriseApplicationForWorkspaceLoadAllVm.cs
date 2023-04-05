using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.WorkSpace;

namespace Application.WorkSpace.Quiries.procEnterpriseApplicationForWorkspace
{
    public class GetprocEnterpriseApplicationForWorkspaceLoadAllVm : IMapFrom<EnterpriseApplicationForWorkspace>
    {
        public System.Guid EAFW_ID { get; set; }
        public string TIN { get; set; }
        public System.Double? Size_M2 { get; set; }
        public string Application { get; set; }
        public System.Guid? Doc_ID { get; set; }
        public bool? IsSubmited { get; set; }
        public System.DateTime? App_Date { get; set; }
        public System.Guid? Application_code { get; set; }
        public System.Guid? Licence_ID { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<EnterpriseApplicationForWorkspace, GetprocEnterpriseApplicationForWorkspaceLoadAllVm>();
        }
    }
}
