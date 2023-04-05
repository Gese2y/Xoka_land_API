using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.WorkSpace;
using XOKA.Domain.Interfaces;

namespace Application.WorkSpace.Quiries.procShedStatus.GetprocShedStatusLoadAll
{
    class GetprocShedStatusLoadAllQueryHandler : IRequestHandler<GetprocShedStatusLoadAllQuery, GetprocShedStatusLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocShedStatusLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocShedStatusLoadAllListVm> Handle(GetprocShedStatusLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<ShedStatus> procShedStatuss = await _procedureAdabter
               .Execute<ShedStatus>("[WorkSpace].[proc_Shed_StatusLoadAll]");
            GetprocShedStatusLoadAllListVm vm = new GetprocShedStatusLoadAllListVm
            {
                procShedStatuss = _mapper.Map<IList<ShedStatus>, IList<GetprocShedStatusLoadAllVm>>(procShedStatuss)
            };

            return vm;
        }
    }
}
