using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    /// <summary>
    /// 手机装饰抽象类
    /// </summary>
    public abstract class Decorate : Phone
    {
        Phone phone = null;
        public void SetDecorate(Phone phone)
        {
            this.phone = phone;
        }
        public override void Show()
        {
            if (this.phone != null)
            {
                this.phone.Show();
            }
        }
    }
    /// <summary>
    /// 配件装饰
    /// </summary>
    public class Accessories : Decorate
    {
        public override void Show()
        {
            base.Show();
            //增加一些业务逻辑
            Console.WriteLine("对手机进行了配件装饰");
        }
    }
    /// <summary>
    /// 贴膜装饰
    /// </summary>
    public class Sticker : Decorate
    {
        public override void Show()
        {
            base.Show();
            //增加一些业务逻辑 
            Console.WriteLine("对手机进行了贴膜装饰");
        }
    }

}
