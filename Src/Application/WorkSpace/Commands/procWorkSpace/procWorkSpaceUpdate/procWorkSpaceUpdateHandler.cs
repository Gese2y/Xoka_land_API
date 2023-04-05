

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.WorkSpace;
using XOKA.Domain.Interfaces;

namespace Application.WorkSpace.Commands.procWorkSpace.procWorkSpaceUpdate.procWorkSpaceUpdateCommand
{

    /// @author  Shimels Alem  proc_Work_SpaceUpdate stored procedure.


    public class procWorkSpaceUpdateHandler : IRequestHandler<procWorkSpaceUpdateCommand, IList<WorkSpace_WorkSpaceID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procWorkSpaceUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<WorkSpace_WorkSpaceID>> Handle( procWorkSpaceUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<WorkSpace_WorkSpaceID> result = await _procedureAdabter
                .Execute<WorkSpace_WorkSpaceID>("[WorkSpace].proc_Work_SpaceUpdate", request);
           

            return result;
        }
    }
}
 