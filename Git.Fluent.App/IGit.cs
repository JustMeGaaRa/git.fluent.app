using Git.Fluent.App.Model;

namespace Git.Fluent.App
{
    public interface IGit :
        ISupportHelpOption<IGit>,
        ICanInit,
        ICanClone,
        ICanCheckout,
        ICanAdd,
        ICanStatus,
        ICanLog,
        ICanFetch,
        ICanPull,
        ICanCommit,
        ICanPush
    {
        IGit Version();
    }
}
