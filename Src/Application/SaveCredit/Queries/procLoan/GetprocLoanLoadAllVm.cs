using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.SaveCredit;

namespace Application.SaveCredit.Quiries.procLoan
{
    public class GetprocLoanLoadAllVm : IMapFrom<Loan>
    {
		public System.Guid Loan_Id { get; set; }
		public System.Guid? ApplicationCodeCreadit { get; set; }
		public long? Member_Id { get; set; }
		public System.Guid? MF { get; set; }
		public System.Double? Amount { get; set; }
		public System.DateTime? Request_Date { get; set; }
		public bool? Approved { get; set; }
		public System.DateTime? Approved_Date { get; set; }
		public string Manual_Approved_By { get; set; }
		public bool? Submited { get; set; }
		public string Loan_Status { get; set; }
		public void Mapping(Profile profile)
        {
            profile.CreateMap<Loan, GetprocLoanLoadAllVm>();
        }
    }
}
