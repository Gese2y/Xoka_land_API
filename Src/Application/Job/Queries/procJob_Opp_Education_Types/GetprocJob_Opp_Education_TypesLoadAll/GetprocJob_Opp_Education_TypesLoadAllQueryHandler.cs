using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Quiries.procJob_Opp_Education_Types.GetprocJob_Opp_Education_TypesLoadAll
{
    class GetprocJob_Opp_Education_TypesLoadAllQueryHandler : IRequestHandler<GetprocJob_Opp_Education_TypesLoadAllQuery, GetprocJob_Opp_Education_TypesLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocJob_Opp_Education_TypesLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocJob_Opp_Education_TypesLoadAllListVm> Handle(GetprocJob_Opp_Education_TypesLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Job_Opp_Education_Types> procJob_Opp_Education_Typess = await _procedureAdabter
               .Execute<Job_Opp_Education_Types>("[Job].[proc_Job_Opp_Education_TypesLoadAll]");
            GetprocJob_Opp_Education_TypesLoadAllListVm vm = new GetprocJob_Opp_Education_TypesLoadAllListVm
            {
                procJob_Opp_Education_Typess = _mapper.Map<IList<Job_Opp_Education_Types>, IList<GetprocJob_Opp_Education_TypesLoadAllVm>>(procJob_Opp_Education_Typess)
            };

            return vm;
        }
    }
}
