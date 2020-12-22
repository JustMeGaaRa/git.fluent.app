namespace Git.Fluent.App
{
    public interface IFetchContext : ICommandBuilder
    {
        IFetchContext All();

        IFetchContext Append();

        IFetchContext Prune();

        IFetchContext Force();
    }
}
