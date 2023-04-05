using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.WorkSpace;
using XOKA.Domain.Interfaces;

namespace Application.WorkSpace.Quiries.procSheds.GetprocShedsLoadAll
{
    class GetprocShedsLoadAllQueryHandler : IRequestHandler<GetprocShedsLoadAllQuery, GetprocShedsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocShedsLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocShedsLoadAllListVm> Handle(GetprocShedsLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Sheds> procShedss = await _procedureAdabter
               .Execute<Sheds>("[WorkSpace].[proc_ShedsLoadAll]");
            GetprocShedsLoadAllListVm vm = new GetprocShedsLoadAllListVm
            {
                procShedss = _mapper.Map<IList<Sheds>, IList<GetprocShedsLoadAllVm>>(procShedss)
            };

            return vm;
        }
    }
}
