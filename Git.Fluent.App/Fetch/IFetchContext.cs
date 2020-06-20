namespace Git.Fluent.App
{
    public interface IFetchContext<T> : ICommand<T>
    {
        IFetchContext<T> All();

        IFetchContext<T> Append();

        IFetchContext<T> Prune();

        IFetchContext<T> Force();
    }
}
