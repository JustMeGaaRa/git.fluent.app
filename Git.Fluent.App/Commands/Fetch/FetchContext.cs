using CliWrap;
using Git.Fluent.App.Abstract.Commands;

namespace Git.Fluent.App
{
    internal class FetchContext : IFetchContext
    {
        private readonly Command _command;

        public FetchContext(Command command)
        {
            _command = command ?? throw new System.ArgumentNullException(nameof(command));
        }

        public ICommand Build() => new CommandWrapper(_command);

        public IFetchContext All() => new FetchContext(_command.WithArguments("--all"));

        public IFetchContext Append() => new FetchContext(_command.WithArguments("--append"));

        public IFetchContext Force() => new FetchContext(_command.WithArguments("--force"));

        public IFetchContext Prune() => new FetchContext(_command.WithArguments("--prune"));
    }
}
