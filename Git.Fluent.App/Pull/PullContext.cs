namespace Git.Fluent.App
{
    internal class PullContext : CommandBase<IGit>, IPullContext<IGit>
    {
        public PullContext(IGit git) : base("pull", git)
        {
        }

        public IPullContext<IGit> Rebase()
        {
            Append("--rebase");
            return this;
        }

        public IPullContext<IGit> All()
        {
            Append("--all");
            return this;
        }

        public IPullContext<IGit> Append()
        {
            Append("--append");
            return this;
        }

        public IPullContext<IGit> Force()
        {
            Append("--force");
            return this;
        }

        public IPullContext<IGit> Prune()
        {
            Append("--prune");
            return this;
        }
    }
}
