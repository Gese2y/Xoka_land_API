



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.DAR;
using XOKA.Domain.Interfaces;


namespace Application.DAR.Commands.procdatatypes.procdatatypesInsert.procdatatypesInsertCommand
{

    /// @author  Shimels Alem  proc_data_typesInsert stored procedure.


    public class procdatatypesInsertHandler : IRequestHandler<procdatatypesInsertCommand, IList<datatypes_datatypecode>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procdatatypesInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<datatypes_datatypecode>> Handle( procdatatypesInsertCommand request, CancellationToken cancellationToken)
        {

            IList<datatypes_datatypecode> result = await _procedureAdabter
                .Execute<datatypes_datatypecode>("[DAR].proc_data_typesInsert", request);
           

            return result;
        }
    }
}
 