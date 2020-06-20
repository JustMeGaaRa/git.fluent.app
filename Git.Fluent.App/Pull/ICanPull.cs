namespace Git.Fluent.App
{
    public interface ICanPull<T>
    {
        IPullContext<T> Pull(Context context);
    }
}
