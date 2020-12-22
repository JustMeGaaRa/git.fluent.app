using CliWrap;
using System;

namespace Git.Fluent.App
{
    public class Git : IGit
    {
        private readonly Command _command;

        private Git(Command command)
        {
            _command = command ?? throw new ArgumentNullException(nameof(command));
        }

        public static IGit New()
        {
            var consoleOutputTarget = PipeTarget.ToStream(Console.OpenStandardOutput());
            var command = Cli.Wrap("git")
                .WithStandardOutputPipe(consoleOutputTarget);
            return new Git(command);
        }

        public IGit Help()
        {
            var command = _command
                .WithArguments("--help");
            return new Git(command);
        }

        public IGit Version()
        {
            var command = _command
                .WithArguments("--help");
            return new Git(command);
        }

        public IInitContext Init() => new InitContext(_command);

        public ICloneContext Clone(string repository)
        {
            var command = _command
                .WithArguments("clone")
                .WithArguments(repository);
            return new CloneContext(command);
        }

        public ICloneContext Clone(string repository, string directory)
        {
            var command = _command
                .WithArguments("clone")
                .WithArguments(repository)
                .WithArguments(directory);
            return new CloneContext(command);
        }

        public ICheckoutContext Checkout() => new CheckoutContext(_command);

        public IAddContext Add(string pathspec)
        {
            var command = _command
                .WithArguments("add")
                .WithArguments(pathspec);
            return new AddContext(command);
        }

        public ICommitContext Commit() => new CommitContext(_command);

        public IFetchContext Fetch() => new FetchContext(_command);

        public ILogContext Log() => new LogContext(_command);

        public IPullContext Pull() => new PullContext(_command);

        public IPushContext Push() => new PushContext(_command);

        public IStatusContext Status(string pathspec)
        {
            var command = _command
                .WithArguments("status")
                .WithArguments(pathspec);
            return new StatusContext(command);
        }
    }
}
