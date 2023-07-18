using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.TVET;
using XOKA.Domain.Interfaces;

namespace Application.TVET.Quiries.procApproved_For_Training.GetApproved_For_TrainingLoadAll
{
    class GetprocApproved_For_TrainingLoadAllQueryHandler : IRequestHandler<GetApproved_For_TrainingLoadAllQuery, GetprocApproved_For_TrainingLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocApproved_For_TrainingLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocApproved_For_TrainingLoadAllListVm> Handle(GetApproved_For_TrainingLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Approved_For_Training> procApproved = await _procedureAdabter
               .Execute<Approved_For_Training>("[TVET].[proc_Approved_For_TrainingLoadAll]");
            GetprocApproved_For_TrainingLoadAllListVm vm = new GetprocApproved_For_TrainingLoadAllListVm
            {
                procApproved = _mapper.Map<IList<Approved_For_Training>, IList<GetprocApproved_For_TrainingLoadAllVm>>(procApproved)
            };

            return vm;
        }
    }
}
