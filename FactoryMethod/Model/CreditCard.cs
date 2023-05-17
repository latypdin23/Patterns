namespace FactoryMethod.Model
{
    internal interface CreditCard
    {
        /// <summary>
        /// Получает тип карты
        /// </summary>
        /// <returns></returns>
        string GetCardType();
        /// <summary>
        /// Получает лимит карты
        /// </summary>
        /// <returns></returns>
        int GetCreditLimit();
        /// <summary>
        /// Получает обслуживание карты
        /// </summary>
        /// <returns></returns>
        int GetAnnualCharge();
    }
}
