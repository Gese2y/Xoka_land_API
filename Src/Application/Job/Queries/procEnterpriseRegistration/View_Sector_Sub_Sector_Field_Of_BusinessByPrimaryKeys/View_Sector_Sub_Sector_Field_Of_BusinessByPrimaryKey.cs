using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Job.Quiries.procEnterpriseRegistration.View_Sector_Sub_Sector_Field_Of_BusinessListVm;

namespace Application.Job.Quiries.procEnterpriseRegistration.View_Sector_Sub_Sector_Field_Of_BusinessByPrimaryKeys
{
    /// @author  Shimels Alem proc_Enterprise_RegistrationLoadByPrimaryKey stored procedure.

    public class View_Sector_Sub_Sector_Field_Of_BusinessByPrimaryKey : IRequest<View_Sector_Sub_Sector_Field_Of_BusinessListVms>
    {
        public string TIN { get; set; }
    }
}
