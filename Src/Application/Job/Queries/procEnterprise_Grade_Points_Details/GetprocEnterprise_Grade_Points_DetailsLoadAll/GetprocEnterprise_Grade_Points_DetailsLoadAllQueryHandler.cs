using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Quiries.procEnterprise_Grade_Points_Details.GetprocEnterprise_Grade_Points_DetailsLoadAll
{
    class GetprocEnterprise_Grade_Points_DetailsLoadAllQueryHandler : IRequestHandler<GetprocEnterprise_Grade_Points_DetailsLoadAllQuery, GetprocEnterprise_Grade_Points_DetailsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocEnterprise_Grade_Points_DetailsLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocEnterprise_Grade_Points_DetailsLoadAllListVm> Handle(GetprocEnterprise_Grade_Points_DetailsLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Enterprise_Grade_Points_Details> procEnterprise_Grade_Points_Details = await _procedureAdabter
               .Execute<Enterprise_Grade_Points_Details>("[dbo].[proc_Enterprise_Grade_Points_DetailsLoadAll]");
            GetprocEnterprise_Grade_Points_DetailsLoadAllListVm vm = new GetprocEnterprise_Grade_Points_DetailsLoadAllListVm
            {
                procEnterprise_Grade_Points_Details = _mapper.Map<IList<Enterprise_Grade_Points_Details>, IList<GetprocEnterprise_Grade_Points_DetailsLoadAllVm>>(procEnterprise_Grade_Points_Details)
            };

            return vm;
        }
    }
}
