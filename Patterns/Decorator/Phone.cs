using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public abstract class Phone
    {
        public abstract void Show();
    }

    public class ApplePhone : Phone
    {
        public override void Show()
        {
            Console.WriteLine("我是iphone手机");
        }
    }
}
