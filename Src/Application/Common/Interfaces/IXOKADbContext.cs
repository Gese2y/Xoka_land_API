using System.Threading;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface IXOKADbContext
    {
        #region Finance

        #endregion

        #region Store

        #endregion

        #region Inventory

        #endregion

        #region HR

        #endregion

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
