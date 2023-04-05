using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.TVET.Quiries.procProgram.GetprocProgramLoadAll;
using XOKA.Domain.Entities.TVET;
using XOKA.Domain.Interfaces;

namespace Application.TVET.Quiries.procProgram.GetprocProgramByPrimaryKey
{
    public class GetprocProgramQueryHandler : IRequestHandler<GetprocProgramByPrimaryKey, GetprocProgramLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocProgramQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocProgramLoadAllListVm> Handle(GetprocProgramByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<Program> procPrograms = await _procedureAdabter
               .Execute<Program>("[TVET].[proc_ProgramLoadByPrimaryKey]", request);
            GetprocProgramLoadAllListVm vm = new GetprocProgramLoadAllListVm
            {
                procPrograms = _mapper.Map<IList<Program>, IList<GetprocProgramLoadAllVm>>(procPrograms)
            };

            return vm;
        }
    }
}
