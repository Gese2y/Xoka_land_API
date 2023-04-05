



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;


namespace Application.Job.Commands.procCommercialRegistration.procCommercialRegistrationInsert.procCommercialRegistrationInsertCommand
{ 
	 
	/// @author  Shimels Alem  proc_Commercial_RegistrationInsert stored procedure.
	 
	 
      public class procCommercialRegistrationInsertHandler : IRequestHandler<procCommercialRegistrationInsertCommand, IList<CommercialRegistration_COMREGNumberAndTIN>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procCommercialRegistrationInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CommercialRegistration_COMREGNumberAndTIN>> Handle( procCommercialRegistrationInsertCommand request, CancellationToken cancellationToken)
        {
            IList<CommercialRegistration_COMREGNumberAndTIN> result = await _procedureAdabter
                    .Execute<CommercialRegistration_COMREGNumberAndTIN>("[Job].proc_Commercial_RegistrationInsert", request);
           
            return result;
        }
    }
}
 