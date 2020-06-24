namespace Git.Fluent.App
{
    public interface IAddContext<T> : ICommand<T>
    {
        IAddContext<T> All();

        IAddContext<T> Pathspec(string pathspec);
    }
}
