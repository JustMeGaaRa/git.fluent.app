namespace Git.Fluent.App
{
    public interface IGit :
        ICanInit<IGit>,
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
