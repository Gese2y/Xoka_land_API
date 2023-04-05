



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;


namespace Application.Job.Commands.procStakeholder_Employee.procStakeholder_EmployeeInsert.procStakeholder_EmployeeInsertCommand
{

    /// @author  Shimels Alem  proc_MSE_EmployeeInsert stored procedure.


    public class procStakeholder_EmployeeInsertHandler : IRequestHandler<procStakeholder_EmployeeInsertCommand, IList<Stakeholder_Employee_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procStakeholder_EmployeeInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Stakeholder_Employee_Id>> Handle( procStakeholder_EmployeeInsertCommand request, CancellationToken cancellationToken)
        {

            IList<Stakeholder_Employee_Id> result = await _procedureAdabter
                .Execute<Stakeholder_Employee_Id>("[Job].proc_Stakeholder_EmployeeInsert", request);
           

            return result;
        }
    }
}
 