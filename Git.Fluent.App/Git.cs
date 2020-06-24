namespace Git.Fluent.App
{
    public class Git : IGit
    {
        public Context Context { get; }

        public IInitContext<IGit> Init(Context context) => new InitContext(this);

        public ICloneContext<IGit> Clone(Context context) => new CloneContext(this);

        public ICheckoutContext<IGit> Checkout(Context context) => new CheckoutContext(this);

        public IAddContext<IGit> Add(Context context) => new AddContext(this);

        public ICommitContext<IGit> Commit(Context context) => new CommitContext(this);

        public IFetchContext<IGit> Fetch(Context context) => new FetchContext(this);

        public ILogContext<IGit> Log(Context context) => new LogContext(this);

        public IPullContext<IGit> Pull(Context context) => new PullContext(this);

        public IPushContext<IGit> Push(Context context) => new PushContext(this);

        public IStatusContext<IGit> Status(Context context) => new StatusContext(this);
    }
}
