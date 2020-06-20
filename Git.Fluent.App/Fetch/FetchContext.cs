namespace Git.Fluent.App
{
    internal class FetchContext : CommandBase<IGit>, IFetchContext<IGit>
    {
        public FetchContext(IGit git) : base("fetch", git)
        {
        }

        public IFetchContext<IGit> All()
        {
            Append("--all");
            return this;
        }

        public IFetchContext<IGit> Append()
        {
            Append("--append");
            return this;
        }

        public IFetchContext<IGit> Force()
        {
            Append("--force");
            return this;
        }

        public IFetchContext<IGit> Prune()
        {
            Append("--prune");
            return this;
        }
    }
}
