namespace Git.Fluent.App
{
    internal class CommitContext : CommandBase<IGit>, ICommitContext<IGit>
    {
        public CommitContext(IGit git) : base("commit", git)
        {
        }
    }
}
