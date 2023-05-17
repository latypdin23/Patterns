namespace TemplateMethod.Model
{
    internal abstract class PieBase
    {
        /// <summary>
        /// Приготовить пирог.
        /// </summary>
        public void Cook()
        {
            CreateDough();
            CreateFilling();
            Fry();
        }

        /// <summary>
        /// Замешать тесто.
        /// </summary>
        protected abstract void CreateDough();

        /// <summary>
        /// Приготовить начинку.
        /// </summary>
        protected abstract void CreateFilling();

        /// <summary>
        /// Запечь пирог в духовке.
        /// </summary>
        protected abstract void Fry();
    }
}
