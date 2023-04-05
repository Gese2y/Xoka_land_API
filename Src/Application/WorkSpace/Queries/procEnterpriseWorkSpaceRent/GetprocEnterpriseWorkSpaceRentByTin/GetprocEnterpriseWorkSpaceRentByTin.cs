using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.WorkSpace.Quiries.procEnterpriseWorkSpaceRent.GetprocEnterpriseWorkSpaceRentLoadAll;

namespace Application.WorkSpace.Quiries.procEnterpriseWorkSpaceRent.GetprocEnterpriseWorkSpaceRentByTin
{
    /// @author  Shimels Alem proc_Enterprise_Work_Space_RentLoadByPrimaryKey stored procedure.

    public class GetprocEnterpriseWorkSpaceRentByTin : IRequest<GetprocEnterpriseWorkSpaceRentLoadAllListVm>
    {
        public string TIN { get; set; }
    }
}
