using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.DAR;
using XOKA.Domain.Interfaces;

namespace Application.DAR.Quiries.procDAR.GetprocDARLoadAll
{
    class GetprocDARLoadAllQueryHandler : IRequestHandler<GetprocDARLoadAllQuery, GetprocDARLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocDARLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocDARLoadAllListVm> Handle(GetprocDARLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<_DAR> procDARs = await _procedureAdabter
               .Execute<_DAR>("[DAR].[proc_DARLoadAll]");
            GetprocDARLoadAllListVm vm = new GetprocDARLoadAllListVm
            {
                procDARs = _mapper.Map<IList<_DAR>, IList<GetprocDARLoadAllVm>>(procDARs)
            };

            return vm;
        }
    }
}
