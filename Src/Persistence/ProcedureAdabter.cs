using System.Collections.Generic;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using XOKA.Common.Helpers;

namespace XOKA.Persistence
{
    public class ProcedureAdabter : IProcedureAdabter
    {
        readonly ISprocRepository _sprocRepository;
        public ProcedureAdabter(ISprocRepository sprocRepository)
        {
            _sprocRepository = sprocRepository;
        }

        public async Task<IList<T>> Execute<T>(string name, params (string, object)[] nameValueParams) where T : class
        {
            return await _sprocRepository
             .GetStoredProcedure(name)
             .WithSqlParams(nameValueParams)
             .ExecuteStoredProcedureAsync<T>();
        }
        public async Task<IList<T>> Execute<T>(string name, object source) where T : class
        {
            XOKA.Common.Helpers.KeyVal<string, object>[] keyValuePairs = source.AsDictionary();
            return await _sprocRepository
             .GetStoredProcedure(name)
             .WithObjectSqlParams(keyValuePairs)
             .ExecuteStoredProcedureAsync<T>();
        }
        public async Task<object> ExecuteForResult(string name, params (string, object)[] nameValueParams)
        {
            return await _sprocRepository
             .GetStoredProcedure(name)
             .WithSqlParams(nameValueParams)
             .ExecuteForResult();
        }
    }
}
