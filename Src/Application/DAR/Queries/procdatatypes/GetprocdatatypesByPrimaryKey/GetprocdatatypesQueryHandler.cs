using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.DAR.Quiries.procdatatypes.GetprocdatatypesLoadAll;
using XOKA.Domain.Entities.DAR;
using XOKA.Domain.Interfaces;

namespace Application.DAR.Quiries.procdatatypes.GetprocdatatypesByPrimaryKey
{
    public class GetprocdatatypesQueryHandler : IRequestHandler<GetprocdatatypesByPrimaryKey, GetprocdatatypesLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocdatatypesQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocdatatypesLoadAllListVm> Handle(GetprocdatatypesByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<datatypes> procdatatypess = await _procedureAdabter
               .Execute<datatypes>("[DAR].[proc_data_typesLoadByPrimaryKey]", request);
            GetprocdatatypesLoadAllListVm vm = new GetprocdatatypesLoadAllListVm
            {
                procdatatypess = _mapper.Map<IList<datatypes>, IList<GetprocdatatypesLoadAllVm>>(procdatatypess)
            };

            return vm;
        }
    }
}
