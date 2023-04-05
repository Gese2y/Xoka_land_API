using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.TVET;
using XOKA.Domain.Interfaces;

namespace Application.TVET.Quiries.procProgram.GetprocProgramLoadAll
{
    class GetprocProgramLoadAllQueryHandler : IRequestHandler<GetprocProgramLoadAllQuery, GetprocProgramLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocProgramLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocProgramLoadAllListVm> Handle(GetprocProgramLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Program> procPrograms = await _procedureAdabter
               .Execute<Program>("[TVET].[proc_ProgramLoadAll]");
            GetprocProgramLoadAllListVm vm = new GetprocProgramLoadAllListVm
            {
                procPrograms = _mapper.Map<IList<Program>, IList<GetprocProgramLoadAllVm>>(procPrograms)
            };

            return vm;
        }
    }
}
