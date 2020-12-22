using CliWrap;
using Git.Fluent.App.Abstract.Commands;

namespace Git.Fluent.App
{
    internal class CommitContext : ICommitContext
    {
        private readonly Command _command;

        public CommitContext(Command command)
        {
            _command = command ?? throw new System.ArgumentNullException(nameof(command));
        }

        public ICommand Build() => new CommandWrapper(_command);

        public ICommitContext All() => new CommitContext(_command.WithArguments("--all"));

        public ICommitContext Author(string author) => new CommitContext(_command.WithArguments("--author").WithArguments(author));

        public ICommitContext Message(string message) => new CommitContext(_command.WithArguments("--message").WithArguments(message));
    }
}
