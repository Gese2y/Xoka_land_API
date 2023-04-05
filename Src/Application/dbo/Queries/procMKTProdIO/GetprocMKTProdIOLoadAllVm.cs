﻿using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.dbo;

namespace Application.dbo.Quiries.procMKTProdIO
{
    public class GetprocMKTProdIOLoadAllVm : IMapFrom<MKTProdIO>
    {
        public System.Guid ID { get; set; }
        public System.Guid? Opp_ID { get; set; }
        public System.Guid? Product_ID { get; set; }
        public bool? INPUT { get; set; }
        public bool? OUTPUT { get; set; }
        public string Unit { get; set; }
        public System.Int32? QTY { get; set; }
        public string Period { get; set; } 
        public System.Double? MIN_Price_With_Out_VAT_Birr { get; set; }
        public System.Double? MIX_Price_With_Out_VAT_Birr { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<MKTProdIO, GetprocMKTProdIOLoadAllVm>();
        }
    }
}
