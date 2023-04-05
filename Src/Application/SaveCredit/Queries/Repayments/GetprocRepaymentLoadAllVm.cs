using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.SaveCredit;

namespace Application.SaveCredit.Quiries.Repayments
{
    public class GetprocRepaymentLoadAllVm : IMapFrom<Repayment>
    {

        public System.Guid LoanID { get; set; }
        public System.Guid UserID { get; set; }
        public System.DateTime? RegistrationDate { get; set; }
        public string LoanAmount { get; set; }
        public string Repayments { get; set; }
        public string Balance { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Repayment, GetprocRepaymentLoadAllVm>();
        }
    }
}
