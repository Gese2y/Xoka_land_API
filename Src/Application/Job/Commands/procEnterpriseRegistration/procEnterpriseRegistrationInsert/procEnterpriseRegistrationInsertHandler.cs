



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;


namespace Application.Job.Commands.procEnterpriseRegistration.procEnterpriseRegistrationInsert.procEnterpriseRegistrationInsertCommand
{

    /// @author  Shimels Alem  proc_Enterprise_RegistrationInsert stored procedure.


    public class procEnterpriseRegistrationInsertHandler : IRequestHandler<procEnterpriseRegistrationInsertCommand, IList<EnterpriseRegistration_TIN>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procEnterpriseRegistrationInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<EnterpriseRegistration_TIN>> Handle( procEnterpriseRegistrationInsertCommand request, CancellationToken cancellationToken)
        {

            IList<EnterpriseRegistration_TIN> result = await _procedureAdabter
                .Execute<EnterpriseRegistration_TIN>("[Job].proc_Enterprise_RegistrationInsert", request);
           

            return result;
        }
    }
}
 