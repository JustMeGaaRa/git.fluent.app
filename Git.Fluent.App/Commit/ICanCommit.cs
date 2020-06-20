namespace Git.Fluent.App
{
    public interface ICanCommit<T>
    {
        ICommitContext<T> Commit(Context context);
    }
}
