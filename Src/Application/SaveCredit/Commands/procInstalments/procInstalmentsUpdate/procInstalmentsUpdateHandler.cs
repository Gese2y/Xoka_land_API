

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.SaveCredit;
using XOKA.Domain.Interfaces;

namespace Application.SaveCredit.Commands.procInstalments.procInstalmentsUpdate.procInstalmentsUpdateCommand
{

    /// @author  Shimels Alem  proc_InstalmentsUpdate stored procedure.


    public class procInstalmentsUpdateHandler : IRequestHandler<procInstalmentsUpdateCommand, IList<Instalments_contractidAndnumber>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procInstalmentsUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Instalments_contractidAndnumber>> Handle( procInstalmentsUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<Instalments_contractidAndnumber> result = await _procedureAdabter
                .Execute<Instalments_contractidAndnumber>("[SaveCredit].proc_InstalmentsUpdate", request);
           

            return result;
        }
    }
}
 