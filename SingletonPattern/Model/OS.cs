using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.Model
{
    internal class OS
    {
        private static OS instance;

        public string Name { get; private set; }

        protected OS(string name)
        {
            this.Name = name;
        }
        /// <summary>
        /// Создаётся экземпляр только в том в случае, если объект не создан
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static OS getInstance(string name)
        {
            if (instance == null)
            {
                instance = new OS(name);
            }
            return instance;
        }
    }
}
