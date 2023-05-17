using StrategyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Model
{
    internal class Cooker
    {
        public string Name { get; set; }
        /// <summary>
        /// Инициализирует объект с заданным именем
        /// </summary>
        /// <param name="name"></param>
        public Cooker(string name)
        {
            this.Name = name;
        }
        /// <summary>
        /// Вывод на экран рецепт блюда. 
        /// </summary>
        /// <param name="meal">Интерфейсная переменная, принимает любой тип, который наследуется от интерфейса IMeal</param>
        public void MakeDinner(IMeal meal)
        {
            meal.Make();
        }
    }
}
