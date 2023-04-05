using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Job.Quiries.procJob_Position.GetprocJob_PositionLoadAll;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Quiries.procJob_Position.GetprocJob_PositionByPrimaryKey
{
    public class GetprocJob_PositionQueryHandler : IRequestHandler<GetprocJob_PositionByPrimaryKey, GetprocJob_PositionLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocJob_PositionQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocJob_PositionLoadAllListVm> Handle(GetprocJob_PositionByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<Job_Position> procJob_Positions = await _procedureAdabter
               .Execute<Job_Position>("[Job].[proc_Job_PositionLoadByPrimaryKey]", request);
            GetprocJob_PositionLoadAllListVm vm = new GetprocJob_PositionLoadAllListVm
            {
                procJob_Positions = _mapper.Map<IList<Job_Position>, IList<GetprocJob_PositionLoadAllVm>>(procJob_Positions)
            };

            return vm;
        }
    }
}
