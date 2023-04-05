
using System.Collections.Generic;
using System.Threading.Tasks;

namespace XOKA.Domain.Interfaces
{
    public interface IProcedureAdabter
    {
        Task<IList<T>> Execute<T>(string name, params (string, object)[] nameValueParams) where T : class;
        Task<IList<T>> Execute<T>(string name, object source) where T : class;
        Task<object> ExecuteForResult(string name, params (string, object)[] nameValueParams);

    }
}
