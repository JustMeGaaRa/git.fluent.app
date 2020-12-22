namespace Git.Fluent.App
{
    public interface ICanAdd
    {
        IAddContext Add(string pathspec);
    }
}
