

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procEnterpriseRegistration.procEnterpriseRegistrationUpdate.procEnterpriseRegistrationUpdateCommand
{

    /// @author  Shimels Alem  proc_Enterprise_RegistrationUpdate stored procedure.


    public class procEnterpriseRegistrationUpdateHandler : IRequestHandler<procEnterpriseRegistrationUpdateCommand, IList<EnterpriseRegistration_TIN>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procEnterpriseRegistrationUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<EnterpriseRegistration_TIN>> Handle( procEnterpriseRegistrationUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<EnterpriseRegistration_TIN> result = await _procedureAdabter
                .Execute<EnterpriseRegistration_TIN>("[Job].proc_Enterprise_RegistrationUpdate", request);
           

            return result;
        }
    }
}
 