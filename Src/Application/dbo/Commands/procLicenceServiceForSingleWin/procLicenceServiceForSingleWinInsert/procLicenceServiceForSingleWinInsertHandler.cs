



using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.dbo;
using XOKA.Domain.Interfaces;


namespace Application.dbo.Commands.procLicenceServiceForSingleWin.procLicenceServiceForSingleWinInsert.procLicenceServiceForSingleWinInsertCommand
{

    /// @author  Shimels Alem  proc_Licence_Service_For_Single_WinInsert stored procedure.


    public class procLicenceServiceForSingleWinInsertHandler : IRequestHandler<procLicenceServiceForSingleWinInsertCommand, IList<LicenceServiceForSingleWin_LicenceId>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procLicenceServiceForSingleWinInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<LicenceServiceForSingleWin_LicenceId>> Handle( procLicenceServiceForSingleWinInsertCommand request, CancellationToken cancellationToken)
        {

            IList<LicenceServiceForSingleWin_LicenceId> result = await _procedureAdabter
                .Execute<LicenceServiceForSingleWin_LicenceId>("[dbo].proc_Licence_Service_For_Single_WinInsert", request);
           

            return result;
        }
    }
}
 