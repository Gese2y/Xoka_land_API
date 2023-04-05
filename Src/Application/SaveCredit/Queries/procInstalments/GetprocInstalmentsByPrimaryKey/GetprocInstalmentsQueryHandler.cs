using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.SaveCredit.Quiries.procInstalments.GetprocInstalmentsLoadAll;
using XOKA.Domain.Entities.SaveCredit;
using XOKA.Domain.Interfaces;

namespace Application.SaveCredit.Quiries.procInstalments.GetprocInstalmentsByPrimaryKey
{
    public class GetprocInstalmentsQueryHandler : IRequestHandler<GetprocInstalmentsByPrimaryKey, GetprocInstalmentsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocInstalmentsQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocInstalmentsLoadAllListVm> Handle(GetprocInstalmentsByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<Instalments> procInstalmentss = await _procedureAdabter
               .Execute<Instalments>("[SaveCredit].[proc_InstalmentsLoadByPrimaryKey]", request);
            GetprocInstalmentsLoadAllListVm vm = new GetprocInstalmentsLoadAllListVm
            {
                procInstalmentss = _mapper.Map<IList<Instalments>, IList<GetprocInstalmentsLoadAllVm>>(procInstalmentss)
            };

            return vm;
        }
    }
}
