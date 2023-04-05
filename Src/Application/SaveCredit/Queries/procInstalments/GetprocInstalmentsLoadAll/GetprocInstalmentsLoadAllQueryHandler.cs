using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.SaveCredit;
using XOKA.Domain.Interfaces;

namespace Application.SaveCredit.Quiries.procInstalments.GetprocInstalmentsLoadAll
{
    class GetprocInstalmentsLoadAllQueryHandler : IRequestHandler<GetprocInstalmentsLoadAllQuery, GetprocInstalmentsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocInstalmentsLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocInstalmentsLoadAllListVm> Handle(GetprocInstalmentsLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Instalments> procInstalmentss = await _procedureAdabter
               .Execute<Instalments>("[SaveCredit].[proc_InstalmentsLoadAll]");
            GetprocInstalmentsLoadAllListVm vm = new GetprocInstalmentsLoadAllListVm
            {
                procInstalmentss = _mapper.Map<IList<Instalments>, IList<GetprocInstalmentsLoadAllVm>>(procInstalmentss)
            };

            return vm;
        }
    }
}
