using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Job.Quiries.procEnterpriseRegistration.View_Sector_Sub_Sector_Field_Of_BusinessListVm;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Quiries.procEnterpriseRegistration.View_Sector_Sub_Sector_Field_Of_BusinessByPrimaryKeys
{
    public class View_Sector_Sub_Sector_Field_Of_BusinessQueryHandler : IRequestHandler<View_Sector_Sub_Sector_Field_Of_BusinessByPrimaryKey,  View_Sector_Sub_Sector_Field_Of_BusinessListVms>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public View_Sector_Sub_Sector_Field_Of_BusinessQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task< View_Sector_Sub_Sector_Field_Of_BusinessListVms> Handle(View_Sector_Sub_Sector_Field_Of_BusinessByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<View_Sector_Sub_Sector_Field_Of_Businessent> procEnterpriseRegistrations = await _procedureAdabter
               .Execute<View_Sector_Sub_Sector_Field_Of_Businessent>("[dbo].[proc_View_Sector_Sub_Sector_Field_Of_Business]", request);
             View_Sector_Sub_Sector_Field_Of_BusinessListVms vm = new  View_Sector_Sub_Sector_Field_Of_BusinessListVms
            {
                procEnterpriseRegistrations = _mapper.Map<IList<View_Sector_Sub_Sector_Field_Of_Businessent>, IList<View_Sector_Sub_Sector_Field_Of_Business>>(procEnterpriseRegistrations)
            };

            return vm;
        }
    }
}
