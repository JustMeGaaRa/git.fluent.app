namespace Git.Fluent.App
{
    internal class AddContext : CommandBase<IGit>, IAddContext<IGit>
    {
        public AddContext(IGit git) : base("add", git)
        {
        }

        public IAddContext<IGit> All()
        {
            Append(".");
            return this;
        }
    }
}
