using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.WorkSpace;
using XOKA.Domain.Interfaces;

namespace Application.WorkSpace.Commands.procWorkSpace.procWorkSpaceDelete.procWorkSpaceDeleteCommand
{

    /// @author  Shimels Alem  proc_Work_SpaceDelete stored procedure.


    public class procWorkSpaceDeleteHandler : IRequestHandler<procWorkSpaceDeleteCommand, IList<WorkSpace_WorkSpaceID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procWorkSpaceDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<WorkSpace_WorkSpaceID>> Handle( procWorkSpaceDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<WorkSpace_WorkSpaceID> result = await _procedureAdabter
                .Execute<WorkSpace_WorkSpaceID>("[WorkSpace].proc_Work_SpaceDelete", request);
           

            return result;
        }
    }
}
  