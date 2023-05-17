using System;

namespace TemplateMethod.Model
{
    internal class MeatPie : PieBase
    {
        /// <inheritdoc />
        protected override void CreateDough()
        {
            Console.WriteLine("Используем дрожжевое тесто.");
        }

        /// <inheritdoc />
        protected override void CreateFilling()
        {
            Console.WriteLine("Используем мясную начинку.");
        }

        /// <inheritdoc />
        protected override void Fry()
        {
            Console.WriteLine("Запекаем в духовке при температуре 210 градусов в течении 50 минут.");
        }

        /// <summary>
        /// Приведение объекта к строке.
        /// </summary>
        /// <returns> Тип пирога. </returns>
        public override string ToString()
        {
            return "Мясной пирог";
        }
    }
}
