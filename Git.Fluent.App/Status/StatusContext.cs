namespace Git.Fluent.App
{
    internal class StatusContext : CommandBase<IGit>, IStatusContext<IGit>
    {
        public StatusContext(IGit git) : base("status", git)
        {
        }

        public IStatusContext<IGit> Branch()
        {
            Append("--branch");
            return this;
        }

        public IStatusContext<IGit> Long()
        {
            Append("--long");
            return this;
        }

        public IStatusContext<IGit> Short()
        {
            Append("--short");
            return this;
        }
    }
}
