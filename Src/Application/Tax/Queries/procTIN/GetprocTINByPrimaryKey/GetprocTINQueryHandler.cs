using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Tax.Quiries.procTIN.GetprocTINLoadAll;
using XOKA.Domain.Entities.Tax;
using XOKA.Domain.Interfaces;

namespace Application.Tax.Quiries.procTIN.GetprocTINByPrimaryKey
{
    public class GetprocTINQueryHandler : IRequestHandler<GetprocTINByPrimaryKey, GetprocTINLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocTINQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocTINLoadAllListVm> Handle(GetprocTINByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<_TIN> procTINs = await _procedureAdabter
               .Execute<_TIN>("[Tax].[proc_TINLoadByPrimaryKey]", request);
            GetprocTINLoadAllListVm vm = new GetprocTINLoadAllListVm
            {
                procTINs = _mapper.Map<IList<_TIN>, IList<GetprocTINLoadAllVm>>(procTINs)
            };

            return vm;
        }
    }
}
