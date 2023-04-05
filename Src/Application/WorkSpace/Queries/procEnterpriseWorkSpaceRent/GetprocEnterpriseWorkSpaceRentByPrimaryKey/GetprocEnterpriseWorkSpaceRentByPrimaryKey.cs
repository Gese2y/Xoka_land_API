using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.WorkSpace.Quiries.procEnterpriseWorkSpaceRent.GetprocEnterpriseWorkSpaceRentLoadAll;

namespace Application.WorkSpace.Quiries.procEnterpriseWorkSpaceRent.GetprocEnterpriseWorkSpaceRentByPrimaryKey
{
    /// @author  Shimels Alem proc_Enterprise_Work_Space_RentLoadByPrimaryKey stored procedure.

    public class GetprocEnterpriseWorkSpaceRentByPrimaryKey : IRequest<GetprocEnterpriseWorkSpaceRentLoadAllListVm>
    {
        public System.Guid Work_Space_ID { get; set; }
        public string TIN { get; set; }
    }
}
