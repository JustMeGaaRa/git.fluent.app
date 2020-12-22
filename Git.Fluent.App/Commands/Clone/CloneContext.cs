using CliWrap;
using Git.Fluent.App.Abstract.Commands;

namespace Git.Fluent.App
{
    internal class CloneContext : ICloneContext
    {
        private readonly Command _command;

        public CloneContext(Command command)
        {
            _command = command ?? throw new System.ArgumentNullException(nameof(command));
        }

        public ICommand Build() => new CommandWrapper(_command);

        public ICloneContext Local() => new CloneContext(_command.WithArguments("--local"));

        public ICloneContext NoHardlinks() => new CloneContext(_command.WithArguments("--no-hardlinks"));

        public ICloneContext Shared() => new CloneContext(_command.WithArguments("--shared"));

        public ICloneContext Reference(string repository) => new CloneContext(_command.WithArguments("--reference").WithArguments(repository));

        public ICloneContext Dissociate() => new CloneContext(_command.WithArguments("--dissociate"));

        public ICloneContext Quite() => new CloneContext(_command.WithArguments("--quite"));

        public ICloneContext Verbose() => new CloneContext(_command.WithArguments("--verbose"));

        public ICloneContext Progress() => new CloneContext(_command.WithArguments("--progress"));

        public ICloneContext NoCheckout() => new CloneContext(_command.WithArguments("--no-checkout"));

        public ICloneContext Bare() => new CloneContext(_command.WithArguments("--base"));

        public ICloneContext Sparse() => new CloneContext(_command.WithArguments("--sparse"));

        public ICloneContext Mirror() => new CloneContext(_command.WithArguments("--mirror"));

        public ICloneContext Branch(string name) => new CloneContext(_command.WithArguments("--branch").WithArguments(name));

        public ICloneContext Origin(string name) => new CloneContext(_command.WithArguments("--origin").WithArguments(name));

        public ICloneContext Template(string templateDirectory) => new CloneContext(_command.WithArguments("--template").WithArguments(templateDirectory));
    }
}
