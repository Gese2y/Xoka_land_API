



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;


namespace Application.Job.Commands.procSub_City_Job_Assignment_Transaction.procSub_City_Job_Assignment_TransactionInsert.procSub_City_Job_Assignment_TransactionInsertCommand
{

    /// @author  Shimels Alem  proc_MSE_EmployeeInsert stored procedure.


    public class procSub_City_Job_Assignment_TransactionInsertHandler : IRequestHandler<procSub_City_Job_Assignment_TransactionInsertCommand, IList<Sub_City_Job_Assignment_Transaction_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procSub_City_Job_Assignment_TransactionInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Sub_City_Job_Assignment_Transaction_ID>> Handle( procSub_City_Job_Assignment_TransactionInsertCommand request, CancellationToken cancellationToken)
        {

            IList<Sub_City_Job_Assignment_Transaction_ID> result = await _procedureAdabter
                .Execute<Sub_City_Job_Assignment_Transaction_ID>("[Job].proc_Sub_City_Job_Assignment_TransactionInsert", request);
           

            return result;
        }
    }
}
 