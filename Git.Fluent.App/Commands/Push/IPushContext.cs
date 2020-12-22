namespace Git.Fluent.App
{
    public interface IPushContext : ICommandBuilder
    {
        IPushContext All();

        IPushContext Force();

        IPushContext SetUpstream();

        IPushContext Remote(string remote);

        IPushContext Ref(string reference);
    }
}
