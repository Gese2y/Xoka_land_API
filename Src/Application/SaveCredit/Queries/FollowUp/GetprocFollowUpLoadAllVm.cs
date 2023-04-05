using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.SaveCredit;

namespace Application.SaveCredit.Queries.FollowUp
{
    public class GetprocFollowUpLoadAllVm : IMapFrom<FolloUpClass>
    {
        public System.Guid FollowID { get; set; }
        public System.Guid UserID { get; set; }
        public System.DateTime? Date { get; set; }
        public string FollowUpBy { get; set; }
        public string ContactNumber { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<FolloUpClass, GetprocFollowUpLoadAllVm>();
        }
    }
}
