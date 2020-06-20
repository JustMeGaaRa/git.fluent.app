using System;

namespace Git.Fluent.App
{
    public class Git : IGit
    {
        public Context Context { get; }

        public IInitContext<IGit> Init(Context context)
        {
            Console.WriteLine(nameof(Init));
            return new InitContext(this);
        }

        public ICheckoutContext<IGit> Checkout(Context context)
        {
            Console.WriteLine(nameof(Checkout));
            return new CheckoutContext(this);
        }

        public IAddContext<IGit> Add(Context context)
        {
            Console.WriteLine(nameof(Add));
            return new AddContext(this);
        }

        public ICommitContext<IGit> Commit(Context context)
        {
            Console.WriteLine(nameof(Commit));
            return new CommitContext(this);
        }

        public IFetchContext<IGit> Fetch(Context context)
        {
            Console.WriteLine(nameof(Fetch));
            return new FetchContext(this);
        }

        public ILogContext<IGit> Log(Context context)
        {
            Console.WriteLine(nameof(Log));
            return new LogContext(this);
        }

        public IPullContext<IGit> Pull(Context context)
        {
            Console.WriteLine(nameof(Pull));
            return new PullContext(this);
        }

        public IPushContext<IGit> Push(Context context)
        {
            Console.WriteLine(nameof(Push));
            return new PushContext(this);
        }

        public IStatusContext<IGit> Status(Context context)
        {
            Console.WriteLine(nameof(Status));
            return new StatusContext(this);
        }
    }
}
