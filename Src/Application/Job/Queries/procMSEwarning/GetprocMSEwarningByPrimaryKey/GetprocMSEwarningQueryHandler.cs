using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Job.Quiries.procMSEwarning.GetprocMSEwarningLoadAll;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Quiries.procMSEwarning.GetprocMSEwarningByPrimaryKey
{
    public class GetprocMSEwarningQueryHandler : IRequestHandler<GetprocMSEwarningByPrimaryKey, GetprocMSEwarningLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocMSEwarningQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocMSEwarningLoadAllListVm> Handle(GetprocMSEwarningByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<MSEwarning> procMSEwarning = await _procedureAdabter
               .Execute<MSEwarning>("[dbo].[proc_Enterprise_WarningLoadByPrimaryKey]", request);
            GetprocMSEwarningLoadAllListVm vm = new GetprocMSEwarningLoadAllListVm
            {
                procMSEwarning = _mapper.Map<IList<MSEwarning>, IList<GetprocMSEwarningLoadAllVm>>(procMSEwarning)
            };

            return vm;
        }
    }
}
