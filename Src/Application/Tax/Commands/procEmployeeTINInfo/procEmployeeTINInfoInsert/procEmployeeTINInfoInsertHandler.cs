



using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Tax;
using XOKA.Domain.Interfaces;


namespace Application.Tax.Commands.procEmployeeTINInfo.procEmployeeTINInfoInsert.procEmployeeTINInfoInsertCommand
{

    /// @author  Shimels Alem  proc_Employee_TIN_InfoInsert stored procedure.


    public class procEmployeeTINInfoInsertHandler : IRequestHandler<procEmployeeTINInfoInsertCommand, IList<EmployeeTINInfo_EmpTINID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procEmployeeTINInfoInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<EmployeeTINInfo_EmpTINID>> Handle( procEmployeeTINInfoInsertCommand request, CancellationToken cancellationToken)
        {

            System.Guid Emp_TIN_ID = request.Emp_TIN_ID;
            string TIN = request.TIN;
            System.DateTime? Date_Issued = request.Date_Issued;
            string Certificate_Code = request.Certificate_Code;
            string Certificate_NO = request.Certificate_NO;
            string First_Name = request.First_Name;
            string Last_Name = request.Last_Name;
            string Middle_Name = request.Middle_Name;
            string Gender = request.Gender;
            System.DateTime? Date_Expired = request.Date_Expired;
            System.DateTime? Date_of_Birth = request.Date_of_Birth;
            byte[] Finger_Print = request.Finger_Print;
            byte[] Photo = request.Photo;
            string Remark = request.Remark;
            bool? IsActive = request.IsActive;
            IList<EmployeeTINInfo_EmpTINID> result = await _procedureAdabter
                    .Execute<EmployeeTINInfo_EmpTINID>("[Tax].proc_Employee_TIN_InfoInsert",
                    (nameof(Emp_TIN_ID), Emp_TIN_ID),
                    (nameof(TIN), TIN),
                    (nameof(Date_Issued), Date_Issued),
                    (nameof(Certificate_Code), Certificate_Code),
                    (nameof(Certificate_NO), Certificate_NO),
                    (nameof(First_Name), First_Name),
                    (nameof(Last_Name), Last_Name),
                    (nameof(Middle_Name), Middle_Name),
                    (nameof(Gender), Gender),
                    (nameof(Date_Expired), Date_Expired),
                    (nameof(Date_of_Birth), Date_of_Birth),
                    (nameof(Finger_Print), Finger_Print),
                    (nameof(Photo), Photo),
                    (nameof(Remark), Remark),
                    (nameof(IsActive), IsActive)
                    );


            return result;
        }
    }
}
 