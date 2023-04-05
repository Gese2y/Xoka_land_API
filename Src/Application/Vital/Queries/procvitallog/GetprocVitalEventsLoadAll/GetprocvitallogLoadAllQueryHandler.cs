using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Vital;
using XOKA.Domain.Interfaces;

namespace Application.Vital.Quiries.procvitallog.GetprocvitallogLoadAll
{
    class GetprocvitallogLoadAllQueryHandler : IRequestHandler<GetprocvitallogLoadAllQuery, GetprocvitallogLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocvitallogLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocvitallogLoadAllListVm> Handle(GetprocvitallogLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<vitallog> procvitallogs = await _procedureAdabter
               .Execute<vitallog>("[Vital].[proc_vitallogLoadAll]");
            GetprocvitallogLoadAllListVm vm = new GetprocvitallogLoadAllListVm
            {
                procvitallogs = _mapper.Map<IList<vitallog>, IList<GetprocvitallogLoadAllVm>>(procvitallogs)
            };

            return vm;
        }
    }
}
