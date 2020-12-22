using CliWrap;
using Git.Fluent.App.Abstract.Commands;

namespace Git.Fluent.App
{
    internal class AddContext : IAddContext
    {
        private readonly Command _command;

        public AddContext(Command command)
        {
            _command = command ?? throw new System.ArgumentNullException(nameof(command));
        }

        public ICommand Build() => new CommandWrapper(_command);

        public IAddContext All() => new AddContext(_command.WithArguments("."));

        public IAddContext DryRun()
        {
            throw new System.NotImplementedException();
        }

        public IAddContext Patch()
        {
            throw new System.NotImplementedException();
        }

        public IAddContext Edit()
        {
            throw new System.NotImplementedException();
        }

        public IAddContext Update()
        {
            throw new System.NotImplementedException();
        }

        public IAddContext NoAll()
        {
            throw new System.NotImplementedException();
        }

        public IAddContext Refresh()
        {
            throw new System.NotImplementedException();
        }

        public IAddContext IgnoreErrors()
        {
            throw new System.NotImplementedException();
        }

        public IAddContext IgnoreMissing()
        {
            throw new System.NotImplementedException();
        }

        public IAddContext Verbose()
        {
            throw new System.NotImplementedException();
        }

        public IAddContext Force()
        {
            throw new System.NotImplementedException();
        }
    }
}
