using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace demoForFormEvent31
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 订单完成事件
        /// </summary>
        public event EventHandler OrderCompleted;

        /// <summary>
        /// 订单选项委托
        /// </summary>
        public delegate void OrderOption();

        public Form1()
        {
            InitializeComponent();
            OrderCompleted -= Form1_OnOrderCompleted;
            OrderCompleted += Form1_OnOrderCompleted;
        }

        //private void Form1_OrderCompleted(object sender, EventArgs e)
        //{
        //    var orderOption = new OrderOption(InitOrderOption);
        //    orderOption.Invoke();
        //}

        private void Form1_OnOrderCompleted(object sender, EventArgs e)
        {
            var orderOption = new OrderOption(InitOrderOption);
            orderOption?.Invoke();
        }

        //private void Form1_OrderCompleted(object sender, EventArgs e)
        //{
        //    OrderOption orderOption = delegate()
        //    {
        //        Console.WriteLine("123");
        //    };
        //    orderOption.Invoke();
        //}

        //private void Form1_OrderCompleted(object sender, EventArgs e)
        //{
        //    OrderOption orderOption = () =>
        //    {
        //        Console.WriteLine("123");
        //    };
        //    orderOption.Invoke();
        //}

        //private void Form1_OrderCompleted(object sender, EventArgs e)
        //{
        //    Func<int, int, int> orderSum = (x, y) =>
        //    {
        //        return x + y;
        //    };
        //    orderSum.Invoke(1, 2);
        //}

        //private void Form1_OrderCompleted(object sender, EventArgs e)
        //{
        //    Action<int, int> orderSum = (x, y) =>
        //    {
        //        Console.WriteLine(x + y);
        //    };
        //    orderSum.Invoke(1,2);
        //}

        //private void Form1_OrderCompleted(object sender, EventArgs e)
        //{
        //    var v = new { Amount = 108, Message = "Hello" };
        //    var x = 1;
        //    var y = 2;
        //    var order = new Order();
        //    var orderSum = (int x, int y) =>
        //    {
        //        Console.WriteLine(x + y);
        //    };
        //    orderSum.Invoke(x, y);
        //}

        public class Order
        {
            public int Id { get; set; }
        }

        //private void Form1_OrderCompleted(object sender, EventArgs e)
        //{
        //    var orders = new List<Order>();
        //    var smallNumbers = orders.Where(n => n.Id < 10);
        //}

        public void InitOrderOption()
        {

        }

        protected override void OnLoad(EventArgs e)
        {
            OrderCompleted.Invoke(this, e);
            base.OnLoad(e);
        }

    }
}
