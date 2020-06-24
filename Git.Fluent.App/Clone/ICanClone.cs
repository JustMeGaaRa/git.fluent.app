namespace Git.Fluent.App
{
    public interface ICanClone<T>
    {
        ICloneContext<T> Clone(Context context);
    }
}
