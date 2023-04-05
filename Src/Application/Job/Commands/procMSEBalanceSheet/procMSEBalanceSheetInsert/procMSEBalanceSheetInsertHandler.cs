



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;


namespace Application.Job.Commands.procMSEBalanceSheet.procMSEBalanceSheetInsert.procMSEBalanceSheetInsertCommand
{

    /// @author  Shimels Alem  proc_MSE_Balance_SheetInsert stored procedure.


    public class procMSEBalanceSheetInsertHandler : IRequestHandler<procMSEBalanceSheetInsertCommand, IList<MSEBalanceSheet_YearAndTIN>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procMSEBalanceSheetInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<MSEBalanceSheet_YearAndTIN>> Handle( procMSEBalanceSheetInsertCommand request, CancellationToken cancellationToken)
        {

            IList<MSEBalanceSheet_YearAndTIN> result = await _procedureAdabter
                .Execute<MSEBalanceSheet_YearAndTIN>("[Job].proc_MSE_Balance_SheetInsert", request);
           

            return result;
        }
    }
}
 