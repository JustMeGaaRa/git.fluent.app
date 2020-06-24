using System;
using System.Text;
using System.Threading.Tasks;

namespace Git.Fluent.App
{
    internal abstract class CommandBase<TContext> : ICommand<TContext>
    {
        private readonly StringBuilder _commandBuilder = new StringBuilder();
        private readonly TContext _context;

        protected CommandBase(string name, TContext context)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _commandBuilder = new StringBuilder($"git {name}");
        }

        public string Name { get; }

        public virtual Task<TContext> Execute()
        {
            Console.WriteLine(_commandBuilder.ToString());
            return Task.FromResult(_context);
        }

        protected CommandBase<TContext> Append(string text)
        {
            _commandBuilder.Append(' ', 1).Append(text);
            return this;
        }
    }
}
