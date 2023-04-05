using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Quiries.procMSEwarning.GetprocMSEwarningLoadAll
{
    class GetprocMSEwarningLoadAllQueryHandler : IRequestHandler<GetprocMSEwarningLoadAllQuery, GetprocMSEwarningLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocMSEwarningLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocMSEwarningLoadAllListVm> Handle(GetprocMSEwarningLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<MSEwarning> procMSEwarning = await _procedureAdabter
               .Execute<MSEwarning>("[dbo].[proc_Enterprise_WarningLoadAll]");
            GetprocMSEwarningLoadAllListVm vm = new GetprocMSEwarningLoadAllListVm
            {
                procMSEwarning = _mapper.Map<IList<MSEwarning>, IList<GetprocMSEwarningLoadAllVm>>(procMSEwarning)
            };

            return vm;
        }
    }
}
