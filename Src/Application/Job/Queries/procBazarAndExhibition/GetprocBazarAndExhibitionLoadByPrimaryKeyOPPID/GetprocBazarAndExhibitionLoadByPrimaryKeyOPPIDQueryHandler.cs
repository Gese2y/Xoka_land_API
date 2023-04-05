using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Job.Quiries.procBazarAndExhibition.GetprocBazarAndExhibitionLoadAll;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Quiries.procBazarAndExhibition.GetprocBazarAndExhibitionLoadByPrimaryKeyOPPID
{
    public class GetprocBazarAndExhibitionQueryHandler : IRequestHandler<GetprocBazarAndExhibitionLoadByPrimaryKeyOPPID, GetprocBazarAndExhibitionLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocBazarAndExhibitionQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocBazarAndExhibitionLoadAllListVm> Handle(GetprocBazarAndExhibitionLoadByPrimaryKeyOPPID request, CancellationToken cancellationToken)
        {
           
            IList<BazarAndExhibition> procBazarAndExhibitions = await _procedureAdabter
               .Execute<BazarAndExhibition>("[Job].[proc_Bazar&ExhibitionLoadByPrimaryKey_OPP_ID]", request);
            GetprocBazarAndExhibitionLoadAllListVm vm = new GetprocBazarAndExhibitionLoadAllListVm
            {
                procBazarAndExhibitions = _mapper.Map<IList<BazarAndExhibition>, IList<GetprocBazarAndExhibitionLoadAllVm>>(procBazarAndExhibitions)
            };

            return vm;
        }
    }
}
