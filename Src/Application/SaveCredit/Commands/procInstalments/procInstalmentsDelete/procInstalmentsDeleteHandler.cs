using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.SaveCredit;
using XOKA.Domain.Interfaces;

namespace Application.SaveCredit.Commands.procInstalments.procInstalmentsDelete.procInstalmentsDeleteCommand
{

    /// @author  Shimels Alem  proc_InstalmentsDelete stored procedure.


    public class procInstalmentsDeleteHandler : IRequestHandler<procInstalmentsDeleteCommand, IList<Instalments_contractidAndnumber>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procInstalmentsDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Instalments_contractidAndnumber>> Handle( procInstalmentsDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<Instalments_contractidAndnumber> result = await _procedureAdabter
                .Execute<Instalments_contractidAndnumber>("[SaveCredit].proc_InstalmentsDelete", request);
           

            return result;
        }
    }
}
  