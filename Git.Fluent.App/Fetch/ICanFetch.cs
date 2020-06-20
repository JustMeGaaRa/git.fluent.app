namespace Git.Fluent.App
{
    public interface ICanFetch<T>
    {
        IFetchContext<T> Fetch(Context context);
    }
}
