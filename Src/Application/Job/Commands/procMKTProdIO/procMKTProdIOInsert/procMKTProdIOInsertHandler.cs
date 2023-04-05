



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using XOKA.Domain.Entities.Job;


namespace Application.Job.Commands.procMKTProdIO.procMKTProdIOInsert.procMKTProdIOInsertCommand
{

    /// @author  Shimels Alem  proc_MKT_Prod_IOInsert stored procedure.


    public class procMKTProdIOInsertHandler : IRequestHandler<procMKTProdIOInsertCommand, IList<MKTProdIO_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procMKTProdIOInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<MKTProdIO_ID>> Handle( procMKTProdIOInsertCommand request, CancellationToken cancellationToken)
        {

            IList<MKTProdIO_ID> result = await _procedureAdabter
                .Execute<MKTProdIO_ID>("[dbo].proc_MKT_Prod_IOInsert", request);
           

            return result;
        }
    }
}
 