using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Vital.Quiries.procvitallog.GetprocvitallogLoadAll;
using XOKA.Domain.Entities.Vital;
using XOKA.Domain.Interfaces;

namespace Application.Vital.Quiries.procvitallog.GetprocvitallogByPrimaryKey
{
    public class GetprocvitallogQueryHandler : IRequestHandler<GetprocvitallogByPrimaryKey, GetprocvitallogLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocvitallogQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocvitallogLoadAllListVm> Handle(GetprocvitallogByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<vitallog> procvitallogs = await _procedureAdabter
               .Execute<vitallog>("[Vital].[proc_vitallogLoadByPrimaryKey]", request);
            GetprocvitallogLoadAllListVm vm = new GetprocvitallogLoadAllListVm
            {
                procvitallogs = _mapper.Map<IList<vitallog>, IList<GetprocvitallogLoadAllVm>>(procvitallogs)
            };

            return vm;
        }
    }
}
