namespace Git.Fluent.App
{
    public interface ICheckoutContext : ICommandBuilder
    {
        ICheckoutContext Branch(string name);

        ICheckoutContext Force();
    }
}
