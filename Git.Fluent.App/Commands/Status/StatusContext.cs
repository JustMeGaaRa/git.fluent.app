using CliWrap;
using Git.Fluent.App.Abstract.Commands;

namespace Git.Fluent.App
{
    internal class StatusContext : IStatusContext
    {
        private readonly Command _command;

        public StatusContext(Command command)
        {
            _command = command ?? throw new System.ArgumentNullException(nameof(command));
        }

        public ICommand Build() => new CommandWrapper(_command);

        public IStatusContext Branch() => new StatusContext(_command.WithArguments("--branch"));

        public IStatusContext Long() => new StatusContext(_command.WithArguments("--long"));

        public IStatusContext Short() => new StatusContext(_command.WithArguments("--short"));
    }
}
