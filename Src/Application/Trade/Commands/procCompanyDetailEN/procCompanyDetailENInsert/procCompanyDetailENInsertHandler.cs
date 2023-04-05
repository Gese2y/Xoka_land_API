



using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Trade;
using XOKA.Domain.Interfaces;


namespace Application.Trade.Commands.procCompanyDetailEN.procCompanyDetailENInsert.procCompanyDetailENInsertCommand
{

    /// @author  Shimels Alem  proc_Company_Detail_ENInsert stored procedure.


    public class procCompanyDetailENInsertHandler : IRequestHandler<procCompanyDetailENInsertCommand, IList<CompanyDetailEN_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procCompanyDetailENInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CompanyDetailEN_ID>> Handle( procCompanyDetailENInsertCommand request, CancellationToken cancellationToken)
        {

            IList<CompanyDetailEN_ID> result = await _procedureAdabter
                .Execute<CompanyDetailEN_ID>("[Trade].proc_Company_Detail_ENInsert", request);
           

            return result;
        }
    }
}
 