using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Job.Quiries.procMKTProdIO.GetprocMKTProdIOLoadAll;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Quiries.procMKTProdIO.GetprocMKTProdIOByPrimaryKey
{
    public class GetprocMKTProdIOQueryHandler : IRequestHandler<GetprocMKTProdIOByPrimaryKey, GetprocMKTProdIOLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocMKTProdIOQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocMKTProdIOLoadAllListVm> Handle(GetprocMKTProdIOByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<MKTProdIO> procMKTProdIOs = await _procedureAdabter
               .Execute<MKTProdIO>("[dbo].[proc_MKT_Prod_IOLoadByPrimaryKey]", request);
            GetprocMKTProdIOLoadAllListVm vm = new GetprocMKTProdIOLoadAllListVm
            {
                procMKTProdIOs = _mapper.Map<IList<MKTProdIO>, IList<GetprocMKTProdIOLoadAllVm>>(procMKTProdIOs)
            };

            return vm;
        }
    }
}
