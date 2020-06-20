namespace Git.Fluent.App
{
    public interface ICanPush<T>
    {
        IPushContext<T> Push(Context context);
    }
}
