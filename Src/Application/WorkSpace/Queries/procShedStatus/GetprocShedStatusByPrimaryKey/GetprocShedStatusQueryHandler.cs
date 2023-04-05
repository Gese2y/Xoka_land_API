using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.WorkSpace.Quiries.procShedStatus.GetprocShedStatusLoadAll;
using XOKA.Domain.Entities.WorkSpace;
using XOKA.Domain.Interfaces;

namespace Application.WorkSpace.Quiries.procShedStatus.GetprocShedStatusByPrimaryKey
{
    public class GetprocShedStatusQueryHandler : IRequestHandler<GetprocShedStatusByPrimaryKey, GetprocShedStatusLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocShedStatusQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocShedStatusLoadAllListVm> Handle(GetprocShedStatusByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<ShedStatus> procShedStatuss = await _procedureAdabter
               .Execute<ShedStatus>("[WorkSpace].[proc_Shed_StatusLoadByPrimaryKey]", request);
            GetprocShedStatusLoadAllListVm vm = new GetprocShedStatusLoadAllListVm
            {
                procShedStatuss = _mapper.Map<IList<ShedStatus>, IList<GetprocShedStatusLoadAllVm>>(procShedStatuss)
            };

            return vm;
        }
    }
}
