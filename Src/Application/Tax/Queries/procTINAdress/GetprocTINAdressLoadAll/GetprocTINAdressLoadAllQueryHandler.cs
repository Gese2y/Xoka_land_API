using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Tax;
using XOKA.Domain.Interfaces;

namespace Application.Tax.Quiries.procTINAdress.GetprocTINAdressLoadAll
{
    class GetprocTINAdressLoadAllQueryHandler : IRequestHandler<GetprocTINAdressLoadAllQuery, GetprocTINAdressLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocTINAdressLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocTINAdressLoadAllListVm> Handle(GetprocTINAdressLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<TINAdress> procTINAdresss = await _procedureAdabter
               .Execute<TINAdress>("[Tax].[proc_TIN_AdressLoadAll]");
            GetprocTINAdressLoadAllListVm vm = new GetprocTINAdressLoadAllListVm
            {
                procTINAdresss = _mapper.Map<IList<TINAdress>, IList<GetprocTINAdressLoadAllVm>>(procTINAdresss)
            };

            return vm;
        }
    }
}
