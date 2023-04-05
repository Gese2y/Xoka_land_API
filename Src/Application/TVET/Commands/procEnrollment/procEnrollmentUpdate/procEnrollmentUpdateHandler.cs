

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.TVET;
using XOKA.Domain.Interfaces;

namespace Application.TVET.Commands.procEnrollment.procEnrollmentUpdate.procEnrollmentUpdateCommand
{

    /// @author  Shimels Alem  proc_EnrollmentUpdate stored procedure.


    public class procEnrollmentUpdateHandler : IRequestHandler<procEnrollmentUpdateCommand, IList<Enrollment_EID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procEnrollmentUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Enrollment_EID>> Handle( procEnrollmentUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<Enrollment_EID> result = await _procedureAdabter
                .Execute<Enrollment_EID>("[TVET].proc_EnrollmentUpdate", request);
           

            return result;
        }
    }
}
 