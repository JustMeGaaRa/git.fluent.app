namespace Git.Fluent.App
{
    public interface ICommitContext : ICommandBuilder
    {
        ICommitContext All();

        ICommitContext Author(string author);

        ICommitContext Message(string message);
    }
}
