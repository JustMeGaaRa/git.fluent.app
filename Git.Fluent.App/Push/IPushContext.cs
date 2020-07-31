namespace Git.Fluent.App
{
    public interface IPushContext<T> : ICommand<IGit>
    {
        IPushContext<T> All();

        IPushContext<T> Force();

        IPushContext<T> SetUpstream();

        IPushContext<T> Remote(string remote);

        IPushContext<T> Ref(string reference);
    }
}
