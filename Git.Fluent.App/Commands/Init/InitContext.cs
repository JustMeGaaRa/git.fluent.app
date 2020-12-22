using CliWrap;
using Git.Fluent.App.Abstract.Commands;

namespace Git.Fluent.App
{
    internal class InitContext : IInitContext
    {
        private readonly Command _command;

        public InitContext(Command command)
        {
            _command = command ?? throw new System.ArgumentNullException(nameof(command));
        }

        public IInitContext Bare()
        {
            throw new System.NotImplementedException();
        }

        public ICommand Build() => new CommandWrapper(_command);

        public IInitContext InitialBranch(string branchName)
        {
            throw new System.NotImplementedException();
        }

        public IInitContext ObjectFormat(string format)
        {
            throw new System.NotImplementedException();
        }

        public IInitContext Quite()
        {
            throw new System.NotImplementedException();
        }

        public IInitContext Shared()
        {
            throw new System.NotImplementedException();
        }

        public IInitContext Template(string templateDirectory)
        {
            throw new System.NotImplementedException();
        }
    }
}
