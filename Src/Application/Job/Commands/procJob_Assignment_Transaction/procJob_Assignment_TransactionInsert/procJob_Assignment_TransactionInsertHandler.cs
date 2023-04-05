



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;


namespace Application.Job.Commands.procJob_Assignment_Transaction.procJob_Assignment_TransactionInsert.procJob_Assignment_TransactionInsertCommand
{

    /// @author  Shimels Alem  proc_MSE_EmployeeInsert stored procedure.


    public class procJob_Assignment_TransactionInsertHandler : IRequestHandler<procJob_Assignment_TransactionInsertCommand, IList<Job_Assignment_Transaction_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procJob_Assignment_TransactionInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Job_Assignment_Transaction_ID>> Handle( procJob_Assignment_TransactionInsertCommand request, CancellationToken cancellationToken)
        {

            IList<Job_Assignment_Transaction_ID> result = await _procedureAdabter
                .Execute<Job_Assignment_Transaction_ID>("[Job].proc_Job_Assignment_TransactionInsert", request);
           

            return result;
        }
    }
}
 