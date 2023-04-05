using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.SaveCredit.Quiries.procCollateral.GetprocCollateralLoadAll;

namespace Application.SaveCredit.Quiries.procCollateral.GetprocCollateralLoadByPrimaryKeyTIN
{
    /// @author  Shimels Alem proc_CollateralLoadByPrimaryKey_TIN stored procedure.

    public class GetprocCollateralLoadByPrimaryKeyTIN : IRequest<GetprocCollateralLoadAllListVm>
    {
        public long TIN { get; set; }
    }
}
