namespace Git.Fluent.App
{
    public interface ICheckoutContext<T> : ICommand<T>
    {
        ICheckoutContext<T> Branch(string name);

        ICheckoutContext<T> Force();
    }
}
