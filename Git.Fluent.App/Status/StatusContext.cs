namespace Git.Fluent.App
{
    internal class StatusContext : CommandBase<IGit>, IStatusContext<IGit>
    {
        public StatusContext(IGit git) : base("status", git)
        {
        }
    }
}
