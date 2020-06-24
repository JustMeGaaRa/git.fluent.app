namespace Git.Fluent.App
{
    public interface ICloneContext<T> : ICommand<T>
    {
        ICloneContext<T> Origin(string name);

        ICloneContext<T> Branch(string name);
    }
}
