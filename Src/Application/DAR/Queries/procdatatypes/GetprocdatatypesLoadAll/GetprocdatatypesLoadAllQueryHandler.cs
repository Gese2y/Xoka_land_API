using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.DAR;
using XOKA.Domain.Interfaces;

namespace Application.DAR.Quiries.procdatatypes.GetprocdatatypesLoadAll
{
    class GetprocdatatypesLoadAllQueryHandler : IRequestHandler<GetprocdatatypesLoadAllQuery, GetprocdatatypesLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocdatatypesLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocdatatypesLoadAllListVm> Handle(GetprocdatatypesLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<datatypes> procdatatypess = await _procedureAdabter
               .Execute<datatypes>("[DAR].[proc_data_typesLoadAll]");
            GetprocdatatypesLoadAllListVm vm = new GetprocdatatypesLoadAllListVm
            {
                procdatatypess = _mapper.Map<IList<datatypes>, IList<GetprocdatatypesLoadAllVm>>(procdatatypess)
            };

            return vm;
        }
    }
}
