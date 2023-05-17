namespace SingletonPattern.Model
{
    internal class Computer
    {
        public OS OS { get; set; }

        /// <summary>
        /// Загрузить ОС на компьютер
        /// </summary>
        /// <param name="osName"></param>
        public void Launch(string osName)
        {
            OS = OS.getInstance(osName);
        }
    }
}
