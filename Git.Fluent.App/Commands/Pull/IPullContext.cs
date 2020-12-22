namespace Git.Fluent.App
{
    public interface IPullContext : ICommandBuilder
    {
        IPullContext Rebase();

        IPullContext All();

        IPullContext Append();

        IPullContext Prune();

        IPullContext Force();
    }
}
