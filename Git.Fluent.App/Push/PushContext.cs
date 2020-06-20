namespace Git.Fluent.App
{
    internal class PushContext : CommandBase<IGit>, IPushContext<IGit>
    {
        public PushContext(IGit git) : base("push", git)
        {
        }
    }
}
