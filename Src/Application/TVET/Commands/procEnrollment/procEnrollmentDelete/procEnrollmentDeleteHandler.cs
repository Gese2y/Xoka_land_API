using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.TVET;
using XOKA.Domain.Interfaces;

namespace Application.TVET.Commands.procEnrollment.procEnrollmentDelete.procEnrollmentDeleteCommand
{

    /// @author  Shimels Alem  proc_EnrollmentDelete stored procedure.


    public class procEnrollmentDeleteHandler : IRequestHandler<procEnrollmentDeleteCommand, IList<Enrollment_EID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procEnrollmentDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Enrollment_EID>> Handle( procEnrollmentDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<Enrollment_EID> result = await _procedureAdabter
                .Execute<Enrollment_EID>("[TVET].proc_EnrollmentDelete", request);
           

            return result;
        }
    }
}
  