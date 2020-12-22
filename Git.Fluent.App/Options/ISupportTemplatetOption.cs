namespace Git.Fluent.App.Model
{
    public interface ISupportTemplatetOption<T>
    {
        T Template(string templateDirectory);
    }
}
