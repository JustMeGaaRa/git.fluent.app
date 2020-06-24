namespace Git.Fluent.App
{
    public interface IStatusContext<T> : ICommand<T>
    {
        IStatusContext<T> Short();

        IStatusContext<T> Long();

        IStatusContext<T> Branch();
    }
}
