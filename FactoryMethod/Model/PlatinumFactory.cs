namespace FactoryMethod.Model
{
    internal class PlatinumFactory : CreditCardFactory
    {
        protected override CreditCard MakeProduct()
        {
            CreditCard product = new Platinum();
            return product;
        }
    }
}
