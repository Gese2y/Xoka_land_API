

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.dbo;
using XOKA.Domain.Interfaces;

namespace Application.dbo.Commands.procLicenceServiceForSingleWin.procLicenceServiceForSingleWinUpdate.procLicenceServiceForSingleWinUpdateCommand
{

    /// @author  Shimels Alem  proc_Licence_Service_For_Single_WinUpdate stored procedure.


    public class procLicenceServiceForSingleWinUpdateHandler : IRequestHandler<procLicenceServiceForSingleWinUpdateCommand, IList<LicenceServiceForSingleWin_LicenceId>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procLicenceServiceForSingleWinUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<LicenceServiceForSingleWin_LicenceId>> Handle( procLicenceServiceForSingleWinUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<LicenceServiceForSingleWin_LicenceId> result = await _procedureAdabter
                .Execute<LicenceServiceForSingleWin_LicenceId>("[dbo].proc_Licence_Service_For_Single_WinUpdate", request);
           

            return result;
        }
    }
}
 