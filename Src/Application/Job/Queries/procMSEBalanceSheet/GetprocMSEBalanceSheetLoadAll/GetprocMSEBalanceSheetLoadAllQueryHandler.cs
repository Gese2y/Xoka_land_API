using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Quiries.procMSEBalanceSheet.GetprocMSEBalanceSheetLoadAll
{
    class GetprocMSEBalanceSheetLoadAllQueryHandler : IRequestHandler<GetprocMSEBalanceSheetLoadAllQuery, GetprocMSEBalanceSheetLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocMSEBalanceSheetLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocMSEBalanceSheetLoadAllListVm> Handle(GetprocMSEBalanceSheetLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<MSEBalanceSheet> procMSEBalanceSheets = await _procedureAdabter
               .Execute<MSEBalanceSheet>("[Job].[proc_MSE_Balance_SheetLoadAll]");
            GetprocMSEBalanceSheetLoadAllListVm vm = new GetprocMSEBalanceSheetLoadAllListVm
            {
                procMSEBalanceSheets = _mapper.Map<IList<MSEBalanceSheet>, IList<GetprocMSEBalanceSheetLoadAllVm>>(procMSEBalanceSheets)
            };

            return vm;
        }
    }
}
