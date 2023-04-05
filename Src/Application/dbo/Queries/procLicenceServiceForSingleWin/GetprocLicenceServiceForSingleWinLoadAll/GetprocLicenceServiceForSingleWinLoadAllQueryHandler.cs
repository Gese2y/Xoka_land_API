using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.dbo;
using XOKA.Domain.Interfaces;

namespace Application.dbo.Quiries.procLicenceServiceForSingleWin.GetprocLicenceServiceForSingleWinLoadAll
{
    class GetprocLicenceServiceForSingleWinLoadAllQueryHandler : IRequestHandler<GetprocLicenceServiceForSingleWinLoadAllQuery, GetprocLicenceServiceForSingleWinLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocLicenceServiceForSingleWinLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocLicenceServiceForSingleWinLoadAllListVm> Handle(GetprocLicenceServiceForSingleWinLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<LicenceServiceForSingleWin> procLicenceServiceForSingleWins = await _procedureAdabter
               .Execute<LicenceServiceForSingleWin>("[dbo].[proc_Licence_Service_For_Single_WinLoadAll]");
            GetprocLicenceServiceForSingleWinLoadAllListVm vm = new GetprocLicenceServiceForSingleWinLoadAllListVm
            {
                procLicenceServiceForSingleWins = _mapper.Map<IList<LicenceServiceForSingleWin>, IList<GetprocLicenceServiceForSingleWinLoadAllVm>>(procLicenceServiceForSingleWins)
            };

            return vm;
        }
    }
}
