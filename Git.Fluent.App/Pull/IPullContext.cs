namespace Git.Fluent.App
{
    public interface IPullContext<T> : ICommand<T>
    {
        IPullContext<T> Rebase();

        IPullContext<T> All();

        IPullContext<T> Append();

        IPullContext<T> Prune();

        IPullContext<T> Force();
    }
}
