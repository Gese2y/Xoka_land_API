using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Job.Quiries.procProduct.GetprocProductLoadAll;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Quiries.procProduct.GetprocProductByPrimaryKey
{
    public class GetprocProductQueryHandler : IRequestHandler<GetprocProductByPrimaryKey, GetprocProductLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocProductQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocProductLoadAllListVm> Handle(GetprocProductByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<Product> procProducts = await _procedureAdabter
               .Execute<Product>("[Job].[proc_ProductLoadByPrimaryKey]", request);
            GetprocProductLoadAllListVm vm = new GetprocProductLoadAllListVm
            {
                procProducts = _mapper.Map<IList<Product>, IList<GetprocProductLoadAllVm>>(procProducts)
            };

            return vm;
        }
    }
}
