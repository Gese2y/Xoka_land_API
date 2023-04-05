

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procMSEBalanceSheet.procMSEBalanceSheetUpdate.procMSEBalanceSheetUpdateCommand
{

    /// @author  Shimels Alem  proc_MSE_Balance_SheetUpdate stored procedure.


    public class procMSEBalanceSheetUpdateHandler : IRequestHandler<procMSEBalanceSheetUpdateCommand, IList<MSEBalanceSheet_YearAndTIN>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procMSEBalanceSheetUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<MSEBalanceSheet_YearAndTIN>> Handle( procMSEBalanceSheetUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<MSEBalanceSheet_YearAndTIN> result = await _procedureAdabter
                .Execute<MSEBalanceSheet_YearAndTIN>("[Job].proc_MSE_Balance_SheetUpdate", request);
           

            return result;
        }
    }
}
 