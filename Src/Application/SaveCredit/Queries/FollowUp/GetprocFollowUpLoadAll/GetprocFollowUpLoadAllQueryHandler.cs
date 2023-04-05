using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.SaveCredit;
using XOKA.Domain.Interfaces;
//using Application.SaveCredit.Quiries.FollowUpF;

namespace Application.SaveCredit.Queries.FollowUp.GetprocFollowUpLoadAll
{
    public class GetprocFollowUpLoadAllQueryHandler : IRequestHandler<GetprocFollowUpLoadAllQuery, GetprocFollowUpLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocFollowUpLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocFollowUpLoadAllListVm> Handle(GetprocFollowUpLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<FolloUpClass> procFolloUpClass = await _procedureAdabter
               .Execute<FolloUpClass>("[Job].[proc_tblFollowUpLoadAll]");
            GetprocFollowUpLoadAllListVm vm = new GetprocFollowUpLoadAllListVm
            {
                procFollowUp = _mapper.Map<IList<FolloUpClass>, IList<GetprocFollowUpLoadAllVm>>(procFolloUpClass)

            };

            return vm;
        }


    }
}
