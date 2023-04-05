

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Trade;
using XOKA.Domain.Interfaces;

namespace Application.Trade.Commands.procCompanyDetailAM.procCompanyDetailAMUpdate.procCompanyDetailAMUpdateCommand
{

    /// @author  Shimels Alem  proc_Company_Detail_AMUpdate stored procedure.


    public class procCompanyDetailAMUpdateHandler : IRequestHandler<procCompanyDetailAMUpdateCommand, IList<CompanyDetailAM_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procCompanyDetailAMUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CompanyDetailAM_ID>> Handle( procCompanyDetailAMUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<CompanyDetailAM_ID> result = await _procedureAdabter
                .Execute<CompanyDetailAM_ID>("[Trade].proc_Company_Detail_AMUpdate", request);
           

            return result;
        }
    }
}
 