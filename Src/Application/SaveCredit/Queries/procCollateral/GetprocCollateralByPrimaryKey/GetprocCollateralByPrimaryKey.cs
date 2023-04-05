using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.SaveCredit.Quiries.procCollateral.GetprocCollateralLoadAll;

namespace Application.SaveCredit.Quiries.procCollateral.GetprocCollateralByPrimaryKey
{
    /// @author  Shimels Alem proc_CollateralLoadByPrimaryKey stored procedure.

    public class GetprocCollateralByPrimaryKey : IRequest<GetprocCollateralLoadAllListVm>
    {
        public System.Guid Collateral_ID { get; set; }
    }
}
