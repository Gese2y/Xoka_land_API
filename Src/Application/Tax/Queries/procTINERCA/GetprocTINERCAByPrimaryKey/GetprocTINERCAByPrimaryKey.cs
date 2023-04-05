using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Tax.Quiries.procTINERCA.GetprocTINERCALoadAll;

namespace Application.Tax.Quiries.procTINERCA.GetprocTINERCAByPrimaryKey
{
    /// @author  Shimels Alem proc_TIN_ERCALoadByPrimaryKey stored procedure.

    public class GetprocTINERCAByPrimaryKey : IRequest<GetprocTINERCALoadAllListVm>
    {
        public string TIN { get; set; }
    }
}
