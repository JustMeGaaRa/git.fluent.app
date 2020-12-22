using CliWrap;
using Git.Fluent.App.Abstract.Commands;

namespace Git.Fluent.App
{
    internal class CheckoutContext : ICheckoutContext
    {
        private readonly Command _command;

        public CheckoutContext(Command command)
        {
            _command = command ?? throw new System.ArgumentNullException(nameof(command));
        }

        public ICommand Build() => new CommandWrapper(_command);

        public ICheckoutContext Branch(string name) => new CheckoutContext(_command.WithArguments(name));

        public ICheckoutContext Force() => new CheckoutContext(_command.WithArguments("--force"));
    }
}
