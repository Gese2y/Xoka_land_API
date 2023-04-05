using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.DAR;
using XOKA.Domain.Interfaces;

namespace Application.DAR.Commands.procdatatypes.procdatatypesDelete.procdatatypesDeleteCommand
{

    /// @author  Shimels Alem  proc_data_typesDelete stored procedure.


    public class procdatatypesDeleteHandler : IRequestHandler<procdatatypesDeleteCommand, IList<datatypes_datatypecode>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procdatatypesDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<datatypes_datatypecode>> Handle( procdatatypesDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<datatypes_datatypecode> result = await _procedureAdabter
                .Execute<datatypes_datatypecode>("[DAR].proc_data_typesDelete", request);
           

            return result;
        }
    }
}
  