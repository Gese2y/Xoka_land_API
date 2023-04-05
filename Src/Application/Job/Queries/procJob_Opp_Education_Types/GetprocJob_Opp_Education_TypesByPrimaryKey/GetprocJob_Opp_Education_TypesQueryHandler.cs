using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Job.Quiries.procJob_Opp_Education_Types.GetprocJob_Opp_Education_TypesLoadAll;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Quiries.procJob_Opp_Education_Types.GetprocJob_Opp_Education_TypesByPrimaryKey
{
    public class GetprocJob_Opp_Education_TypesQueryHandler : IRequestHandler<GetprocJob_Opp_Education_TypesByPrimaryKey, GetprocJob_Opp_Education_TypesLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocJob_Opp_Education_TypesQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocJob_Opp_Education_TypesLoadAllListVm> Handle(GetprocJob_Opp_Education_TypesByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<Job_Opp_Education_Types> procJob_Opp_Education_Typess = await _procedureAdabter
               .Execute<Job_Opp_Education_Types>("[Job].[proc_Job_Opp_Education_TypesLoadByPrimaryKey]", request);
            GetprocJob_Opp_Education_TypesLoadAllListVm vm = new GetprocJob_Opp_Education_TypesLoadAllListVm
            {
                procJob_Opp_Education_Typess = _mapper.Map<IList<Job_Opp_Education_Types>, IList<GetprocJob_Opp_Education_TypesLoadAllVm>>(procJob_Opp_Education_Typess)
            };

            return vm;
        }
    }
}
