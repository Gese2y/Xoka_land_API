using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.dbo;
using XOKA.Domain.Interfaces;

namespace Application.dbo.Commands.procLicenceServiceForSingleWin.procLicenceServiceForSingleWinDelete.procLicenceServiceForSingleWinDeleteCommand
{

    /// @author  Shimels Alem  proc_Licence_Service_For_Single_WinDelete stored procedure.


    public class procLicenceServiceForSingleWinDeleteHandler : IRequestHandler<procLicenceServiceForSingleWinDeleteCommand, IList<LicenceServiceForSingleWin_LicenceId>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procLicenceServiceForSingleWinDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<LicenceServiceForSingleWin_LicenceId>> Handle( procLicenceServiceForSingleWinDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<LicenceServiceForSingleWin_LicenceId> result = await _procedureAdabter
                .Execute<LicenceServiceForSingleWin_LicenceId>("[dbo].proc_Licence_Service_For_Single_WinDelete", request);
           

            return result;
        }
    }
}
  