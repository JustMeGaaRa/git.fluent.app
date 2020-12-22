using Git.Fluent.App.Model;

namespace Git.Fluent.App
{
    public interface ICloneContext :
        ICommandBuilder,
        ISupportQuiteOption<ICloneContext>,
        ISupportBareOption<ICloneContext>,
        ISupportSharedOption<ICloneContext>,
        ISupportTemplatetOption<ICloneContext>,
        ISupportVerboseOption<ICloneContext>
    {
        ICloneContext Local();
        
        ICloneContext NoHardlinks();

        ICloneContext Reference(string repository);

        ICloneContext Dissociate();

        ICloneContext Progress();

        ICloneContext NoCheckout();

        ICloneContext Sparse();

        ICloneContext Mirror();

        ICloneContext Origin(string name);

        ICloneContext Branch(string name);
    }
}
