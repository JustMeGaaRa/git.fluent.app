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
    }
}
