namespace Git.Fluent.App
{
    public interface ICanInit<T>
    {
        IInitContext<T> Init(Context context);
    }
}
