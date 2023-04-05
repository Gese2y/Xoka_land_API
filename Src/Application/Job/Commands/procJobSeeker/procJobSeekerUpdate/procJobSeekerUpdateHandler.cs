

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procJobSeeker.procJobSeekerUpdate.procJobSeekerUpdateCommand
{

    /// @author  Shimels Alem  proc_Job_SeekerUpdate stored procedure.


    public class procJobSeekerUpdateHandler : IRequestHandler<procJobSeekerUpdateCommand, IList<JobSeeker_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procJobSeekerUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<JobSeeker_ID>> Handle( procJobSeekerUpdateCommand request, CancellationToken cancellationToken)
        {
            Guid ID = request.ID;
            Guid? TIN = request.TIN;
            string First_Name = request.First_Name;
            string Last_Name = request.Last_Name;
            string middle_Nmae = request.middle_Nmae;
            string Address = request.Address;
            string Expernce_Level = request.Expernce_Level;
            byte[]? Certfication = request.Certfication;
            int? Phone = request.Phone;
            string Job_Type = request.Job_Type;
            IList<JobSeeker_ID> result = await _procedureAdabter
                .Execute<JobSeeker_ID>("[Job].proc_Job_SeekerUpdate",
                    (nameof(ID), ID),
                    (nameof(TIN), TIN),
                    (nameof(First_Name), First_Name),
                    (nameof(Last_Name), Last_Name),
                    (nameof(middle_Nmae), middle_Nmae),
                    (nameof(Address), Address),
                    (nameof(Expernce_Level), Expernce_Level),
                    (nameof(Certfication), Certfication),
                    (nameof(Phone), Phone),
                    (nameof(Job_Type), Job_Type)
                );

            return result;
        }
    }
}
 