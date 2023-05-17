namespace FactoryMethod.Model
{
    internal abstract class CreditCardFactory
    {
        /// <summary>
        /// Создает продукт кредитной карты
        /// </summary>
        /// <returns></returns>
        protected abstract CreditCard MakeProduct();
        /// <summary>
        /// Создает продукт(кредитную карту)
        /// </summary>
        /// <returns></returns>
        public CreditCard CreateProduct()
        {
            return this.MakeProduct();
        }
    }
}
