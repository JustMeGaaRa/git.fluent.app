namespace Git.Fluent.App
{
    public interface ICanAdd<T>
    {
        IAddContext<T> Add(Context context);
    }
}
