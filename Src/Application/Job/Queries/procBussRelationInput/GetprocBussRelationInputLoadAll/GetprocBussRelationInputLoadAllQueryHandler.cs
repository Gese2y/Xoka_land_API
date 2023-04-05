using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Quiries.procBussRelationInput.GetprocBussRelationInputLoadAll
{
    class GetprocBussRelationInputLoadAllQueryHandler : IRequestHandler<GetprocBussRelationInputLoadAllQuery, GetprocBussRelationInputLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocBussRelationInputLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocBussRelationInputLoadAllListVm> Handle(GetprocBussRelationInputLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<BussRelationInput> procBussRelationInputs = await _procedureAdabter
               .Execute<BussRelationInput>("[Job].[proc_Buss_Relation_InputLoadAll]");
            GetprocBussRelationInputLoadAllListVm vm = new GetprocBussRelationInputLoadAllListVm
            {
                procBussRelationInputs = _mapper.Map<IList<BussRelationInput>, IList<GetprocBussRelationInputLoadAllVm>>(procBussRelationInputs)
            };

            return vm;
        }
    }
}
