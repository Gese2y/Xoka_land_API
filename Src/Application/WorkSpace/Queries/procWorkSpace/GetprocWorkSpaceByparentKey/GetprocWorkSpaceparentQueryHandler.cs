using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.WorkSpace.Quiries.procWorkSpace.GetprocWorkSpaceLoadAll;
using XOKA.Domain.Entities.WorkSpace;
using XOKA.Domain.Interfaces;

namespace Application.WorkSpace.Quiries.procWorkSpace.GetprocWorkSpaceByparentKey
{
    public class GetprocWorkSpaceparentQueryHandler : IRequestHandler<GetprocWorkSpaceByParentKey, GetprocWorkSpaceLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocWorkSpaceparentQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocWorkSpaceLoadAllListVm> Handle(GetprocWorkSpaceByParentKey request, CancellationToken cancellationToken)
        {
           
            IList<_WorkSpace> procWorkSpaces = await _procedureAdabter
               .Execute<_WorkSpace>("[WorkSpace].[proc_Work_SpaceLoadByparentKey]", request);
            GetprocWorkSpaceLoadAllListVm vm = new GetprocWorkSpaceLoadAllListVm
            {
                procWorkSpaces = _mapper.Map<IList<_WorkSpace>, IList<GetprocWorkSpaceLoadAllVm>>(procWorkSpaces)
            };

            return vm;
        }
    }
}
