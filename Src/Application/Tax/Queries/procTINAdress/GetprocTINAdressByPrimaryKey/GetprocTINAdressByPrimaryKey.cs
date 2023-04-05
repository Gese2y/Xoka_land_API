using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Tax.Quiries.procTINAdress.GetprocTINAdressLoadAll;

namespace Application.Tax.Quiries.procTINAdress.GetprocTINAdressByPrimaryKey
{
    /// @author  Shimels Alem proc_TIN_AdressLoadByPrimaryKey stored procedure.

    public class GetprocTINAdressByPrimaryKey : IRequest<GetprocTINAdressLoadAllListVm>
    {
        public System.Guid ID { get; set; }
    }
}
