namespace Git.Fluent.App
{
    internal class CheckoutContext : CommandBase<IGit>, ICheckoutContext<IGit>
    {
        public CheckoutContext(IGit git) : base("checkout", git)
        {
        }

        public ICheckoutContext<IGit> Branch(string name)
        {
            Append(name);
            return this;
        }

        public ICheckoutContext<IGit> Force()
        {
            Append("--force");
            return this;
        }
    }
}
