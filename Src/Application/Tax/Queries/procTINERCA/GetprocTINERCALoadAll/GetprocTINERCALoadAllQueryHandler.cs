using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Tax;
using XOKA.Domain.Interfaces;

namespace Application.Tax.Quiries.procTINERCA.GetprocTINERCALoadAll
{
    class GetprocTINERCALoadAllQueryHandler : IRequestHandler<GetprocTINERCALoadAllQuery, GetprocTINERCALoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocTINERCALoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocTINERCALoadAllListVm> Handle(GetprocTINERCALoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<TINERCA> procTINERCAs = await _procedureAdabter
               .Execute<TINERCA>("[Tax].[proc_TIN_ERCALoadAll]");
            GetprocTINERCALoadAllListVm vm = new GetprocTINERCALoadAllListVm
            {
                procTINERCAs = _mapper.Map<IList<TINERCA>, IList<GetprocTINERCALoadAllVm>>(procTINERCAs)
            };

            return vm;
        }
    }
}
