using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.SaveCredit;
using XOKA.Domain.Interfaces;
namespace Application.SaveCredit.Commands.Repayment.procRepaymentDelete.procRepaymentDeleteCommand
{
    public class proRepaymentDeleteHandler : IRequestHandler<procRepaymentDeleteCommand, IList<Repayment_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proRepaymentDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Repayment_ID>> Handle(procRepaymentDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<Repayment_ID> result = await _procedureAdabter
                .Execute<Repayment_ID>("[Job].proc_tblRepaymentDelete", request);


            return result;
        }
    }
}
