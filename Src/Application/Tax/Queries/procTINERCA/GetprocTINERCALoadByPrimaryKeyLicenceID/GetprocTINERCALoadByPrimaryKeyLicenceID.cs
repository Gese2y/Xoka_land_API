using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Tax.Quiries.procTINERCA.GetprocTINERCALoadAll;

namespace Application.Tax.Quiries.procTINERCA.GetprocTINERCALoadByPrimaryKeyLicenceID
{
    /// @author  Shimels Alem proc_TIN_ERCALoadByPrimaryKey_Licence_ID stored procedure.

    public class GetprocTINERCALoadByPrimaryKeyLicenceID : IRequest<GetprocTINERCALoadAllListVm>
    {
        public System.Guid Licence_ID { get; set; }
    }
}
