namespace Git.Fluent.App
{
    public interface ICommitContext<T> : ICommand<T>
    {
        ICommitContext<T> All();

        ICommitContext<T> Author(string author);

        ICommitContext<T> Message(string message);
    }
}
