namespace Git.Fluent.App
{
    internal class PushContext : CommandBase<IGit>, IPushContext<IGit>
    {
        public PushContext(IGit git) : base("push", git)
        {
        }

        public IPushContext<IGit> All()
        {
            Append("--all");
            return this;
        }

        public IPushContext<IGit> Force()
        {
            Append("--force");
            return this;
        }

        public IPushContext<IGit> Ref(string reference)
        {
            Append(reference);
            return this;
        }

        public IPushContext<IGit> Remote(string remote)
        {
            Append($"remote {remote}");
            return this;
        }

        public IPushContext<IGit> SetUpstream()
        {
            Append("--set-upstream");
            return this;
        }
    }
}
