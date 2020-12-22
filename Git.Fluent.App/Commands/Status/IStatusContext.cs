namespace Git.Fluent.App
{
    public interface IStatusContext : ICommandBuilder
    {
        IStatusContext Short();

        IStatusContext Long();

        IStatusContext Branch();
    }
}
