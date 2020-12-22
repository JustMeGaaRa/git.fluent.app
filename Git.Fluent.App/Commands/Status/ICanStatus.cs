namespace Git.Fluent.App
{
    public interface ICanStatus
    {
        IStatusContext Status(string pathspec);
    }
}
