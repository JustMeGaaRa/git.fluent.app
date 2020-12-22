using CliWrap;
using Git.Fluent.App.Abstract.Commands;

namespace Git.Fluent.App
{
    internal class PushContext : IPushContext
    {
        private readonly Command _command;

        public PushContext(Command command)
        {
            _command = command ?? throw new System.ArgumentNullException(nameof(command));
        }

        public ICommand Build() => new CommandWrapper(_command);

        public IPushContext All() => new PushContext(_command.WithArguments("--all"));

        public IPushContext Force() => new PushContext(_command.WithArguments("--force"));

        public IPushContext Ref(string reference) => new PushContext(_command.WithArguments(reference));

        public IPushContext Remote(string remote) => new PushContext(_command.WithArguments("remote").WithArguments(remote));

        public IPushContext SetUpstream() => new PushContext(_command.WithArguments("--set-upstream"));
    }
}
