using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Quiries.procBranch.GetprocBranchLoadAll
{
    class GetprocBranchLoadAllQueryHandler : IRequestHandler<GetprocBranchLoadAllQuery, GetprocBranchLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocBranchLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocBranchLoadAllListVm> Handle(GetprocBranchLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Branch> procBranchs = await _procedureAdabter
               .Execute<Branch>("[Job].[proc_BranchLoadAll]");
            GetprocBranchLoadAllListVm vm = new GetprocBranchLoadAllListVm
            {
                procBranchs = _mapper.Map<IList<Branch>, IList<GetprocBranchLoadAllVm>>(procBranchs)
            };

            return vm;
        }
    }
}
