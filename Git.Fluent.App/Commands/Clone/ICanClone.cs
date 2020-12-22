namespace Git.Fluent.App
{
    public interface ICanClone
    {
        ICloneContext Clone(string repository);

        ICloneContext Clone(string repository, string directory);
    }
}
