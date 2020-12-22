using CliWrap;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Git.Fluent.App.Abstract.Commands
{
    public class CommandWrapper : ICommand
    {
        private readonly Command _command;

        public CommandWrapper(Command command)
        {
            _command = command ?? throw new ArgumentNullException(nameof(command));
        }

        public async Task<int> ExecuteAsync(CancellationToken token)
        {
            var result = _command.ExecuteAsync(token);
            await result.Task;
            return result.Task.Result.ExitCode;
        }
    }
}
