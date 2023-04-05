using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Job.Quiries.procAssets.GetprocAssetsLoadAll;

namespace Application.Job.Quiries.procAssets.GetprocAssetsByPrimaryKey
{
    /// @author  Shimels Alem proc_AssetsLoadByPrimaryKey stored procedure.

    public class GetprocAssetsByPrimaryKey : IRequest<GetprocAssetsLoadAllListVm>
    {
        public string FIXED_Asset_No { get; set; }
    }
}
