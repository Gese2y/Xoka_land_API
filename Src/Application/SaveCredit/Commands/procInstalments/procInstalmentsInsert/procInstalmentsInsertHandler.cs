



using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.SaveCredit;
using XOKA.Domain.Interfaces;


namespace Application.SaveCredit.Commands.procInstalments.procInstalmentsInsert.procInstalmentsInsertCommand
{

    /// @author  Shimels Alem  proc_InstalmentsInsert stored procedure.


    public class procInstalmentsInsertHandler : IRequestHandler<procInstalmentsInsertCommand, IList<Instalments_contractidAndnumber>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procInstalmentsInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Instalments_contractidAndnumber>> Handle( procInstalmentsInsertCommand request, CancellationToken cancellationToken)
        {

            IList<Instalments_contractidAndnumber> result = await _procedureAdabter
                .Execute<Instalments_contractidAndnumber>("[SaveCredit].proc_InstalmentsInsert", request);
           

            return result;
        }
    }
}
 