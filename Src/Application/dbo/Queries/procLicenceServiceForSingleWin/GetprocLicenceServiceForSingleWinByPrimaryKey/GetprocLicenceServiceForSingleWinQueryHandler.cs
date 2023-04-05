using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.dbo.Quiries.procLicenceServiceForSingleWin.GetprocLicenceServiceForSingleWinLoadAll;
using XOKA.Domain.Entities.dbo;
using XOKA.Domain.Interfaces;

namespace Application.dbo.Quiries.procLicenceServiceForSingleWin.GetprocLicenceServiceForSingleWinByPrimaryKey
{
    public class GetprocLicenceServiceForSingleWinQueryHandler : IRequestHandler<GetprocLicenceServiceForSingleWinByPrimaryKey, GetprocLicenceServiceForSingleWinLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocLicenceServiceForSingleWinQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocLicenceServiceForSingleWinLoadAllListVm> Handle(GetprocLicenceServiceForSingleWinByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<LicenceServiceForSingleWin> procLicenceServiceForSingleWins = await _procedureAdabter
               .Execute<LicenceServiceForSingleWin>("[dbo].[proc_Licence_Service_For_Single_WinLoadByPrimaryKey]", request);
            GetprocLicenceServiceForSingleWinLoadAllListVm vm = new GetprocLicenceServiceForSingleWinLoadAllListVm
            {
                procLicenceServiceForSingleWins = _mapper.Map<IList<LicenceServiceForSingleWin>, IList<GetprocLicenceServiceForSingleWinLoadAllVm>>(procLicenceServiceForSingleWins)
            };

            return vm;
        }
    }
}
