namespace FactoryMethod.Model
{
    internal class MoneyBankFactory : CreditCardFactory
    {
        protected override CreditCard MakeProduct()
        {
            CreditCard product = new MoneyBank();
            return product;
        }
    }
}
