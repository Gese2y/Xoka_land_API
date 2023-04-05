using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.DAR.Quiries.procdatatypes.GetprocdatatypesLoadAll;

namespace Application.DAR.Quiries.procdatatypes.GetprocdatatypesByPrimaryKey
{
    /// @author  Shimels Alem proc_data_typesLoadByPrimaryKey stored procedure.

    public class GetprocdatatypesByPrimaryKey : IRequest<GetprocdatatypesLoadAllListVm>
    {
        public System.Guid data_type_code { get; set; }
    }
}
