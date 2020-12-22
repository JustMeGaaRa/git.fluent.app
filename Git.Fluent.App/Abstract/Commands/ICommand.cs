using System.Threading;
using System.Threading.Tasks;

namespace Git.Fluent.App
{
    public interface ICommand
    {
        Task<int> ExecuteAsync(CancellationToken token);
    }
}
