using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procJobSeeker.procJobSeekerDelete.procJobSeekerDeleteCommand
{

    /// @author  Shimels Alem  proc_Job_SeekerDelete stored procedure.


    public class procJobSeekerDeleteHandler : IRequestHandler<procJobSeekerDeleteCommand, IList<JobSeeker_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procJobSeekerDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<JobSeeker_ID>> Handle( procJobSeekerDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<JobSeeker_ID> result = await _procedureAdabter
                .Execute<JobSeeker_ID>("[Job].proc_Job_SeekerDelete", request);
           

            return result;
        }
    }
}
  