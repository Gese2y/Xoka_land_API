

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procBusinessOppoForjobCreation.procBusinessOppoForjobCreationUpdate.procBusinessOppoForjobCreationUpdateCommand
{

    /// @author  Shimels Alem  proc_Business_Oppo_For__job_CreationUpdate stored procedure.


    public class procBusinessOppoForjobCreationUpdateHandler : IRequestHandler<procBusinessOppoForjobCreationUpdateCommand, IList<BusinessOppoForjobCreation_BUSOPPID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procBusinessOppoForjobCreationUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<BusinessOppoForjobCreation_BUSOPPID>> Handle( procBusinessOppoForjobCreationUpdateCommand request, CancellationToken cancellationToken)
        {
            System.Guid BUS_OPP_ID = request.BUS_OPP_ID;
            string Code = request.Code;
            string Name = request.Name;
            string Sector = request.Sector;
            string Sub_Sector = request.Sub_Sector;
            string Other_Sector = request.Other_Sector;
            string Objective = request.Objective;
            string Profitable_Percent = request.Profitable_Percent;
            byte[]? Business_Plan = request.Business_Plan;
            System.DateTime? Date = request.Date;
            System.Int32? JobOpen_For_ENT = request.JobOpen_For_ENT;
            System.Int32? Job_Open_For_Job_Seeker = request.Job_Open_For_Job_Seeker;
            IList<BusinessOppoForjobCreation_BUSOPPID> result = await _procedureAdabter
                .Execute<BusinessOppoForjobCreation_BUSOPPID>("[Job].proc_Business_Oppo_For__job_CreationUpdate", (nameof(BUS_OPP_ID), BUS_OPP_ID),
                 (nameof(Code), Code),
                 (nameof(Name), Name),
                 (nameof(Sector), Sector),
                 (nameof(Sub_Sector), Sub_Sector),
                 (nameof(Other_Sector), Other_Sector),
                 (nameof(Objective), Objective),
                 (nameof(Profitable_Percent), Profitable_Percent),
                 (nameof(Business_Plan), Business_Plan),
                 (nameof(Date), Date),
                 (nameof(JobOpen_For_ENT), JobOpen_For_ENT),
                 (nameof(Job_Open_For_Job_Seeker), Job_Open_For_Job_Seeker)
                );

            return result;
        }
    }
}
 