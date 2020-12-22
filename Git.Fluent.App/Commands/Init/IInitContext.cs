using Git.Fluent.App.Model;

namespace Git.Fluent.App
{
    public interface IInitContext : 
        ICommandBuilder,
        ISupportQuiteOption<IInitContext>,
        ISupportBareOption<IInitContext>,
        ISupportSharedOption<IInitContext>,
        ISupportTemplatetOption<IInitContext>
    {
        IInitContext ObjectFormat(string format);

        IInitContext InitialBranch(string branchName);
    }
}
