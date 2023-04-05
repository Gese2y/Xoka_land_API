using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.WorkSpace;
using XOKA.Domain.Interfaces;

namespace Application.WorkSpace.Commands.procEnterpriseWorkSpaceRent.procEnterpriseWorkSpaceRentDelete.procEnterpriseWorkSpaceRentDeleteCommand
{

    /// @author  Shimels Alem  proc_Enterprise_Work_Space_RentDelete stored procedure.


    public class procEnterpriseWorkSpaceRentDeleteHandler : IRequestHandler<procEnterpriseWorkSpaceRentDeleteCommand, IList<EnterpriseWorkSpaceRent_WorkSpaceIDAndTIN>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procEnterpriseWorkSpaceRentDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<EnterpriseWorkSpaceRent_WorkSpaceIDAndTIN>> Handle( procEnterpriseWorkSpaceRentDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<EnterpriseWorkSpaceRent_WorkSpaceIDAndTIN> result = await _procedureAdabter
                .Execute<EnterpriseWorkSpaceRent_WorkSpaceIDAndTIN>("[WorkSpace].proc_Enterprise_Work_Space_RentDelete", request);
           

            return result;
        }
    }
}
  