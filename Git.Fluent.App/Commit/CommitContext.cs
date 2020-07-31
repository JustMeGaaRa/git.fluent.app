namespace Git.Fluent.App
{
    internal class CommitContext : CommandBase<IGit>, ICommitContext<IGit>
    {
        public CommitContext(IGit git) : base("commit", git)
        {
        }

        public ICommitContext<IGit> All()
        {
            Append("--all");
            return this;
        }

        public ICommitContext<IGit> Author(string author)
        {
            Append($"--author={author}");
            return this;
        }

        public ICommitContext<IGit> Message(string message)
        {
            Append($"--message={message}");
            return this;
        }
    }
}
