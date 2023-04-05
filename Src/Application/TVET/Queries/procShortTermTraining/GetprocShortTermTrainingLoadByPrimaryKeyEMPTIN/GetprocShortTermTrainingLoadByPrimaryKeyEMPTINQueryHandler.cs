using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.TVET.Quiries.procShortTermTraining.GetprocShortTermTrainingLoadAll;
using XOKA.Domain.Entities.TVET;
using XOKA.Domain.Interfaces;

namespace Application.TVET.Quiries.procShortTermTraining.GetprocShortTermTrainingLoadByPrimaryKeyEMPTIN
{
    public class GetprocShortTermTrainingQueryHandler : IRequestHandler<GetprocShortTermTrainingLoadByPrimaryKeyEMPTIN, GetprocShortTermTrainingLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocShortTermTrainingQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocShortTermTrainingLoadAllListVm> Handle(GetprocShortTermTrainingLoadByPrimaryKeyEMPTIN request, CancellationToken cancellationToken)
        {
           
            IList<ShortTermTraining> procShortTermTrainings = await _procedureAdabter
               .Execute<ShortTermTraining>("[TVET].[proc_Short_Term_TrainingLoadByPrimaryKey_EMP_TIN]", request);
            GetprocShortTermTrainingLoadAllListVm vm = new GetprocShortTermTrainingLoadAllListVm
            {
                procShortTermTrainings = _mapper.Map<IList<ShortTermTraining>, IList<GetprocShortTermTrainingLoadAllVm>>(procShortTermTrainings)
            };

            return vm;
        }
    }
}
