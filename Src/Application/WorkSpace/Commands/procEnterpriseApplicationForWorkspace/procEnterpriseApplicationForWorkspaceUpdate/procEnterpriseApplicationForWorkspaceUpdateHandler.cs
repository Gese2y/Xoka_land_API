

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.WorkSpace;
using XOKA.Domain.Interfaces;

namespace Application.WorkSpace.Commands.procEnterpriseApplicationForWorkspace.procEnterpriseApplicationForWorkspaceUpdate.procEnterpriseApplicationForWorkspaceUpdateCommand
{

    /// @author  Shimels Alem  proc_Enterprise_Application_For_WorkspaceUpdate stored procedure.


    public class procEnterpriseApplicationForWorkspaceUpdateHandler : IRequestHandler<procEnterpriseApplicationForWorkspaceUpdateCommand, IList<EnterpriseApplicationForWorkspace_EAFWID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procEnterpriseApplicationForWorkspaceUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<EnterpriseApplicationForWorkspace_EAFWID>> Handle( procEnterpriseApplicationForWorkspaceUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<EnterpriseApplicationForWorkspace_EAFWID> result = await _procedureAdabter
                .Execute<EnterpriseApplicationForWorkspace_EAFWID>("[WorkSpace].proc_Enterprise_Application_For_WorkspaceUpdate", request);
           

            return result;
        }
    }
}
 