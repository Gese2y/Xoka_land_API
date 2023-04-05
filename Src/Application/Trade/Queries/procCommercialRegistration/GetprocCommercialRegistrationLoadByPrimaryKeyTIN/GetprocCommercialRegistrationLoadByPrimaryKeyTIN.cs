using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Trade.Quiries.procCommercialRegistration.GetprocCommercialRegistrationLoadAll;

namespace Application.Trade.Quiries.procCommercialRegistration.GetprocCommercialRegistrationLoadByPrimaryKeyTIN
{
    /// @author  Shimels Alem proc_Commercial_RegistrationLoadByPrimaryKey_TIN stored procedure.

    public class GetprocCommercialRegistrationLoadByPrimaryKeyTIN : IRequest<GetprocCommercialRegistrationLoadAllListVm>
    {
        public long TIN { get; set; }
    }
}
