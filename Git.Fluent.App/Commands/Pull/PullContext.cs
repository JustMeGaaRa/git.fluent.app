using CliWrap;
using Git.Fluent.App.Abstract.Commands;

namespace Git.Fluent.App
{
    internal class PullContext : IPullContext
    {
        private readonly Command _command;

        public PullContext(Command command)
        {
            _command = command ?? throw new System.ArgumentNullException(nameof(command));
        }

        public ICommand Build() => new CommandWrapper(_command);

        public IPullContext Rebase() => new PullContext(_command.WithArguments("--rebase"));

        public IPullContext All() => new PullContext(_command.WithArguments("--all"));

        public IPullContext Append() => new PullContext(_command.WithArguments("--append"));

        public IPullContext Force() => new PullContext(_command.WithArguments("--force"));

        public IPullContext Prune() => new PullContext(_command.WithArguments("--prune"));
    }
}
