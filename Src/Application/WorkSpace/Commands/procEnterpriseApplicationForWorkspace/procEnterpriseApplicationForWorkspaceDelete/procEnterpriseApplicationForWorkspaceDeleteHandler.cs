using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.WorkSpace;
using XOKA.Domain.Interfaces;

namespace Application.WorkSpace.Commands.procEnterpriseApplicationForWorkspace.procEnterpriseApplicationForWorkspaceDelete.procEnterpriseApplicationForWorkspaceDeleteCommand
{

    /// @author  Shimels Alem  proc_Enterprise_Application_For_WorkspaceDelete stored procedure.


    public class procEnterpriseApplicationForWorkspaceDeleteHandler : IRequestHandler<procEnterpriseApplicationForWorkspaceDeleteCommand, IList<EnterpriseApplicationForWorkspace_EAFWID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procEnterpriseApplicationForWorkspaceDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<EnterpriseApplicationForWorkspace_EAFWID>> Handle( procEnterpriseApplicationForWorkspaceDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<EnterpriseApplicationForWorkspace_EAFWID> result = await _procedureAdabter
                .Execute<EnterpriseApplicationForWorkspace_EAFWID>("[WorkSpace].proc_Enterprise_Application_For_WorkspaceDelete", request);
           

            return result;
        }
    }
}
  