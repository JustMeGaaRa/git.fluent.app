namespace Git.Fluent.App
{
    internal class CloneContext : CommandBase<IGit>, ICloneContext<IGit>
    {
        public CloneContext(IGit context) : base("clone", context)
        {
        }

        public ICloneContext<IGit> Branch(string name)
        {
            Append($"--branch {name}");
            return this;
        }

        public ICloneContext<IGit> Origin(string name)
        {
            Append($"--origin {name}");
            return this;
        }
    }
}
