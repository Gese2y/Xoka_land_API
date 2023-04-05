using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Trade.Quiries.procCommercialRegistration.GetprocCommercialRegistrationLoadAll;

namespace Application.Trade.Quiries.procCommercialRegistration.GetprocCommercialRegistrationByPrimaryKey
{
    /// @author  Shimels Alem proc_Commercial_RegistrationLoadByPrimaryKey stored procedure.

    public class GetprocCommercialRegistrationByPrimaryKey : IRequest<GetprocCommercialRegistrationLoadAllListVm>
    {
        public string COM_REG_Number { get; set; }
    }
}
