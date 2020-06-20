using System.Threading.Tasks;

namespace Git.Fluent.App
{
    public interface ICommand<T>
    {
        string Name { get; }

        Task<T> Execute();
    }
}
