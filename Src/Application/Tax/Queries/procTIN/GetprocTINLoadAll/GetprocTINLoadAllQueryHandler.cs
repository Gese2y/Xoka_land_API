using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Tax;
using XOKA.Domain.Interfaces;

namespace Application.Tax.Quiries.procTIN.GetprocTINLoadAll
{
    class GetprocTINLoadAllQueryHandler : IRequestHandler<GetprocTINLoadAllQuery, GetprocTINLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocTINLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocTINLoadAllListVm> Handle(GetprocTINLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<_TIN> procTINs = await _procedureAdabter
               .Execute<_TIN>("[Tax].[proc_TINLoadAll]");
            GetprocTINLoadAllListVm vm = new GetprocTINLoadAllListVm
            {
                procTINs = _mapper.Map<IList<_TIN>, IList<GetprocTINLoadAllVm>>(procTINs)
            };

            return vm;
        }
    }
}
