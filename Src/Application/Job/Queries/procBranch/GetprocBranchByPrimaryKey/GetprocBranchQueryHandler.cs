using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Job.Quiries.procBranch.GetprocBranchLoadAll;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Quiries.procBranch.GetprocBranchByPrimaryKey
{
    public class GetprocBranchQueryHandler : IRequestHandler<GetprocBranchByPrimaryKey, GetprocBranchLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocBranchQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocBranchLoadAllListVm> Handle(GetprocBranchByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<Branch> procBranchs = await _procedureAdabter
               .Execute<Branch>("[Job].[proc_BranchLoadByPrimaryKey]", request);
            GetprocBranchLoadAllListVm vm = new GetprocBranchLoadAllListVm
            {
                procBranchs = _mapper.Map<IList<Branch>, IList<GetprocBranchLoadAllVm>>(procBranchs)
            };

            return vm;
        }
    }
}
