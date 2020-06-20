namespace Git.Fluent.App
{
    public interface IPullContext<T> : ICommand<T>
    {
        IPullContext<T> Rebase();
    }
}
