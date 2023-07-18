



using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.TVET;
using XOKA.Domain.Interfaces;


namespace Application.TVET.Commands.procApproved_For_Training.Insert.procApproved_For_TrainingInsertCommand
{

    /// @author  Shimels Alem  proc_AttendanceInsert stored procedure.


    public class procApproved_For_TrainingHandler : IRequestHandler<procApproved_For_TrainingInsertCommand, IList<Approved_For_TrainingID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procApproved_For_TrainingHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Approved_For_TrainingID>> Handle(procApproved_For_TrainingInsertCommand request, CancellationToken cancellationToken)
        {

            IList<Approved_For_TrainingID> result = await _procedureAdabter
                .Execute<Approved_For_TrainingID>("[TVET].[proc_Approved_For_TrainingInsert]", request);
           

            return result;
        }
    }
}
 