using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Quiries.procProduct.GetprocProductLoadAll
{
    class GetprocProductLoadAllQueryHandler : IRequestHandler<GetprocProductLoadAllQuery, GetprocProductLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocProductLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocProductLoadAllListVm> Handle(GetprocProductLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Product> procProducts = await _procedureAdabter
               .Execute<Product>("[Job].[proc_ProductLoadAll]");
            GetprocProductLoadAllListVm vm = new GetprocProductLoadAllListVm
            {
                procProducts = _mapper.Map<IList<Product>, IList<GetprocProductLoadAllVm>>(procProducts)
            };

            return vm;
        }
    }
}
