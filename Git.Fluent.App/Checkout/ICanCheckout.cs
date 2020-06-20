namespace Git.Fluent.App
{
    public interface ICanCheckout<T>
    {
        ICheckoutContext<T> Checkout(Context context);
    }
}
