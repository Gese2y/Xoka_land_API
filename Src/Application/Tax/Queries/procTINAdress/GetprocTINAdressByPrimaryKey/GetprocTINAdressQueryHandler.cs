using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Tax.Quiries.procTINAdress.GetprocTINAdressLoadAll;
using XOKA.Domain.Entities.Tax;
using XOKA.Domain.Interfaces;

namespace Application.Tax.Quiries.procTINAdress.GetprocTINAdressByPrimaryKey
{
    public class GetprocTINAdressQueryHandler : IRequestHandler<GetprocTINAdressByPrimaryKey, GetprocTINAdressLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocTINAdressQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocTINAdressLoadAllListVm> Handle(GetprocTINAdressByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<TINAdress> procTINAdresss = await _procedureAdabter
               .Execute<TINAdress>("[Tax].[proc_TIN_AdressLoadByPrimaryKey]", request);
            GetprocTINAdressLoadAllListVm vm = new GetprocTINAdressLoadAllListVm
            {
                procTINAdresss = _mapper.Map<IList<TINAdress>, IList<GetprocTINAdressLoadAllVm>>(procTINAdresss)
            };

            return vm;
        }
    }
}
