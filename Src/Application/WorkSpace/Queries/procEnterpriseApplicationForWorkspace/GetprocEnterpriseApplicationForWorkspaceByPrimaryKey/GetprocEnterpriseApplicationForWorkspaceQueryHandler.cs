using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.WorkSpace.Quiries.procEnterpriseApplicationForWorkspace.GetprocEnterpriseApplicationForWorkspaceLoadAll;
using XOKA.Domain.Entities.WorkSpace;
using XOKA.Domain.Interfaces;

namespace Application.WorkSpace.Quiries.procEnterpriseApplicationForWorkspace.GetprocEnterpriseApplicationForWorkspaceByPrimaryKey
{
    public class GetprocEnterpriseApplicationForWorkspaceQueryHandler : IRequestHandler<GetprocEnterpriseApplicationForWorkspaceByPrimaryKey, GetprocEnterpriseApplicationForWorkspaceLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocEnterpriseApplicationForWorkspaceQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocEnterpriseApplicationForWorkspaceLoadAllListVm> Handle(GetprocEnterpriseApplicationForWorkspaceByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<EnterpriseApplicationForWorkspace> procEnterpriseApplicationForWorkspaces = await _procedureAdabter
               .Execute<EnterpriseApplicationForWorkspace>("[WorkSpace].[proc_Enterprise_Application_For_WorkspaceLoadByPrimaryKey]", request);
            GetprocEnterpriseApplicationForWorkspaceLoadAllListVm vm = new GetprocEnterpriseApplicationForWorkspaceLoadAllListVm
            {
                procEnterpriseApplicationForWorkspaces = _mapper.Map<IList<EnterpriseApplicationForWorkspace>, IList<GetprocEnterpriseApplicationForWorkspaceLoadAllVm>>(procEnterpriseApplicationForWorkspaces)
            };

            return vm;
        }
    }
}
