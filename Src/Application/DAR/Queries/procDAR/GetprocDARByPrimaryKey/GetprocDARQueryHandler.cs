using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.DAR.Quiries.procDAR.GetprocDARLoadAll;
using XOKA.Domain.Entities.DAR;
using XOKA.Domain.Interfaces;

namespace Application.DAR.Quiries.procDAR.GetprocDARByPrimaryKey
{
    public class GetprocDARQueryHandler : IRequestHandler<GetprocDARByPrimaryKey, GetprocDARLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocDARQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocDARLoadAllListVm> Handle(GetprocDARByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<_DAR> procDARs = await _procedureAdabter
               .Execute<_DAR>("[DAR].[proc_DARLoadByPrimaryKey]", request);
            GetprocDARLoadAllListVm vm = new GetprocDARLoadAllListVm
            {
                procDARs = _mapper.Map<IList<_DAR>, IList<GetprocDARLoadAllVm>>(procDARs)
            };

            return vm;
        }
    }
}
