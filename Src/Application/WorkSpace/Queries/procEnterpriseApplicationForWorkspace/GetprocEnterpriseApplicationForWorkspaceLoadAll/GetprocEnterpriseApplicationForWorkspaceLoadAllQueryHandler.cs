using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.WorkSpace;
using XOKA.Domain.Interfaces;

namespace Application.WorkSpace.Quiries.procEnterpriseApplicationForWorkspace.GetprocEnterpriseApplicationForWorkspaceLoadAll
{
    class GetprocEnterpriseApplicationForWorkspaceLoadAllQueryHandler : IRequestHandler<GetprocEnterpriseApplicationForWorkspaceLoadAllQuery, GetprocEnterpriseApplicationForWorkspaceLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocEnterpriseApplicationForWorkspaceLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocEnterpriseApplicationForWorkspaceLoadAllListVm> Handle(GetprocEnterpriseApplicationForWorkspaceLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<EnterpriseApplicationForWorkspace> procEnterpriseApplicationForWorkspaces = await _procedureAdabter
               .Execute<EnterpriseApplicationForWorkspace>("[WorkSpace].[proc_Enterprise_Application_For_WorkspaceLoadAll]");
            GetprocEnterpriseApplicationForWorkspaceLoadAllListVm vm = new GetprocEnterpriseApplicationForWorkspaceLoadAllListVm
            {
                procEnterpriseApplicationForWorkspaces = _mapper.Map<IList<EnterpriseApplicationForWorkspace>, IList<GetprocEnterpriseApplicationForWorkspaceLoadAllVm>>(procEnterpriseApplicationForWorkspaces)
            };

            return vm;
        }
    }
}
