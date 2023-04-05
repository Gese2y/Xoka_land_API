



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;


namespace Application.Compress.Commands.Compress.CompressInsert.CompressInsertCommand
{ 
	 
	/// @author  Shimels Alem  XXXX stored procedure.
	 
	 
      public class CompressInsertHandler : IRequestHandler<CompressInsertCommand>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public CompressInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<Unit> Handle(CompressInsertCommand request, CancellationToken cancellationToken)
        {
            byte[] base64Data = request.base64Data;
            object result = await _procedureAdabter
                .Execute<object>(" sp ",
                    (nameof(base64Data), base64Data)
                    );



            return Unit.Value;
        }
    }
}
