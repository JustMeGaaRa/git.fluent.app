namespace Git.Fluent.App
{
    public interface ICanStatus<T>
    {
        IStatusContext<T> Status(Context context);
    }
}
