

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Trade;
using XOKA.Domain.Interfaces;

namespace Application.Trade.Commands.procCompanyDetailEN.procCompanyDetailENUpdate.procCompanyDetailENUpdateCommand
{

    /// @author  Shimels Alem  proc_Company_Detail_ENUpdate stored procedure.


    public class procCompanyDetailENUpdateHandler : IRequestHandler<procCompanyDetailENUpdateCommand, IList<CompanyDetailEN_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procCompanyDetailENUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CompanyDetailEN_ID>> Handle( procCompanyDetailENUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<CompanyDetailEN_ID> result = await _procedureAdabter
                .Execute<CompanyDetailEN_ID>("[Trade].proc_Company_Detail_ENUpdate", request);
           

            return result;
        }
    }
}
 