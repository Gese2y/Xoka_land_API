using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Trade;
using XOKA.Domain.Interfaces;

namespace Application.Trade.Commands.procCompanyDetailAM.procCompanyDetailAMDelete.procCompanyDetailAMDeleteCommand
{

    /// @author  Shimels Alem  proc_Company_Detail_AMDelete stored procedure.


    public class procCompanyDetailAMDeleteHandler : IRequestHandler<procCompanyDetailAMDeleteCommand, IList<CompanyDetailAM_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procCompanyDetailAMDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CompanyDetailAM_ID>> Handle( procCompanyDetailAMDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<CompanyDetailAM_ID> result = await _procedureAdabter
                .Execute<CompanyDetailAM_ID>("[Trade].proc_Company_Detail_AMDelete", request);
           

            return result;
        }
    }
}
  