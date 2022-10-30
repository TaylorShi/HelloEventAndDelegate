using System;

namespace demoForConsoleEvent31
{
    internal class Program
    {
        /// <summary>
        /// 订单完成事件
        /// </summary>
        public event EventHandler OrderCompleted;

        /// <summary>
        /// 订单选项委托
        /// </summary>
        public delegate void OrderOption();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
