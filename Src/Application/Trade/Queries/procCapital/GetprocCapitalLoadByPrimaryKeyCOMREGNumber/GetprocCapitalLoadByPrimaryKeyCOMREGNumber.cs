using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Trade.Quiries.procCapital.GetprocCapitalLoadAll;

namespace Application.Trade.Quiries.procCapital.GetprocCapitalLoadByPrimaryKeyCOMREGNumber
{
    /// @author  Shimels Alem proc_CapitalLoadByPrimaryKey_COM_REG_Number stored procedure.

    public class GetprocCapitalLoadByPrimaryKeyCOMREGNumber : IRequest<GetprocCapitalLoadAllListVm>
    {
        public string COM_REG_Number { get; set; }
    }
}
