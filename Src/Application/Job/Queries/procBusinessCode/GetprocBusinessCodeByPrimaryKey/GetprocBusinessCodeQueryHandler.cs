using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Job.Quiries.procBusinessCode.GetprocBusinessCodeLoadAll;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Quiries.procBusinessCode.GetprocBusinessCodeByPrimaryKey
{
    public class GetprocBusinessCodeQueryHandler : IRequestHandler<GetprocBusinessCodeByPrimaryKey, GetprocBusinessCodeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocBusinessCodeQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocBusinessCodeLoadAllListVm> Handle(GetprocBusinessCodeByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<BusinessCode> procBusinessCodes = await _procedureAdabter
               .Execute<BusinessCode>("[Job].[proc_Business_CodeLoadByPrimaryKey]", request);
            GetprocBusinessCodeLoadAllListVm vm = new GetprocBusinessCodeLoadAllListVm
            {
                procBusinessCodes = _mapper.Map<IList<BusinessCode>, IList<GetprocBusinessCodeLoadAllVm>>(procBusinessCodes)
            };

            return vm;
        }
    }
}
