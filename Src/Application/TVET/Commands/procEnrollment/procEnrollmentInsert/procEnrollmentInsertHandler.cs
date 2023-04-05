



using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.TVET;
using XOKA.Domain.Interfaces;


namespace Application.TVET.Commands.procEnrollment.procEnrollmentInsert.procEnrollmentInsertCommand
{

    /// @author  Shimels Alem  proc_EnrollmentInsert stored procedure.


    public class procEnrollmentInsertHandler : IRequestHandler<procEnrollmentInsertCommand, IList<Enrollment_EID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procEnrollmentInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Enrollment_EID>> Handle( procEnrollmentInsertCommand request, CancellationToken cancellationToken)
        {

            IList<Enrollment_EID> result = await _procedureAdabter
                .Execute<Enrollment_EID>("[TVET].proc_EnrollmentInsert", request);
           

            return result;
        }
    }
}
 