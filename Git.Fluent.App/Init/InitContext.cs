namespace Git.Fluent.App
{
    internal class InitContext : CommandBase<IGit>, IInitContext<IGit>
    {
        public InitContext(IGit git) : base("init", git)
        {
        }
    }
}
