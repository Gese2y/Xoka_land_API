using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Job.Quiries.procProduct.GetprocProductLoadAll;

namespace Application.Job.Quiries.procProduct.GetprocProductByPrimaryKey
{
    /// @author  Shimels Alem proc_ProductLoadByPrimaryKey stored procedure.

    public class GetprocProductByPrimaryKey : IRequest<GetprocProductLoadAllListVm>
    {
        public Guid ID { get; set; }
    }
}
