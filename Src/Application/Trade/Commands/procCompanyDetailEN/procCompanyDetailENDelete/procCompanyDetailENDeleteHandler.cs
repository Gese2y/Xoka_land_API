using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Trade;
using XOKA.Domain.Interfaces;

namespace Application.Trade.Commands.procCompanyDetailEN.procCompanyDetailENDelete.procCompanyDetailENDeleteCommand
{

    /// @author  Shimels Alem  proc_Company_Detail_ENDelete stored procedure.


    public class procCompanyDetailENDeleteHandler : IRequestHandler<procCompanyDetailENDeleteCommand, IList<CompanyDetailEN_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procCompanyDetailENDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CompanyDetailEN_ID>> Handle( procCompanyDetailENDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<CompanyDetailEN_ID> result = await _procedureAdabter
                .Execute<CompanyDetailEN_ID>("[Trade].proc_Company_Detail_ENDelete", request);
           

            return result;
        }
    }
}
  