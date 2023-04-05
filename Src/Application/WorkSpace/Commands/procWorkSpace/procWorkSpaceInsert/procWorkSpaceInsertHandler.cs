



using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.WorkSpace;
using XOKA.Domain.Interfaces;


namespace Application.WorkSpace.Commands.procWorkSpace.procWorkSpaceInsert.procWorkSpaceInsertCommand
{

    /// @author  Shimels Alem  proc_Work_SpaceInsert stored procedure.


    public class procWorkSpaceInsertHandler : IRequestHandler<procWorkSpaceInsertCommand, IList<WorkSpace_WorkSpaceID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procWorkSpaceInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<WorkSpace_WorkSpaceID>> Handle( procWorkSpaceInsertCommand request, CancellationToken cancellationToken)
        {

            IList<WorkSpace_WorkSpaceID> result = await _procedureAdabter
                .Execute<WorkSpace_WorkSpaceID>("[WorkSpace].proc_Work_SpaceInsert", request);
           

            return result;
        }
    }
}
 