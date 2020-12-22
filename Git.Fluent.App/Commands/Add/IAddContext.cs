using Git.Fluent.App.Model;

namespace Git.Fluent.App
{
    public interface IAddContext : 
        ICommandBuilder,
        ISupportVerboseOption<IAddContext>,
        ISupportForceOption<IAddContext>
    {
        IAddContext DryRun();

        IAddContext Patch();

        IAddContext Edit();

        IAddContext Update();

        IAddContext All();

        IAddContext NoAll();

        IAddContext Refresh();

        IAddContext IgnoreErrors();

        IAddContext IgnoreMissing();
    }
}
