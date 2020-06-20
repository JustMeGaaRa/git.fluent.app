namespace Git.Fluent.App
{
    internal class CheckoutContext : CommandBase<IGit>, ICheckoutContext<IGit>
    {
        public CheckoutContext(IGit git) : base("checkout", git)
        {
        }
    }
}
