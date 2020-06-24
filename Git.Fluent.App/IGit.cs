namespace Git.Fluent.App
{
    public interface IGit :
        ICanInit<IGit>,
        ICanClone<IGit>,
        ICanCheckout<IGit>,
        ICanAdd<IGit>,
        ICanStatus<IGit>,
        ICanLog<IGit>,
        ICanFetch<IGit>,
        ICanPull<IGit>,
        ICanCommit<IGit>,
        ICanPush<IGit>
    {
        Context Context { get; }
    }
}
