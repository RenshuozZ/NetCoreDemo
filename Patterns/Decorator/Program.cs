using System;


namespace Decorator
{
    /// <summary>
    /// 装饰着模式调用
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new ApplePhone();
            Decorate sticker = new Sticker();
            Decorate accessories = new Accessories();
            //将贴膜装到手机上。。。
            sticker.SetDecorate(phone);
            //将配件装到贴膜手机上。。。
            accessories.SetDecorate(sticker);
            //最后将完整的手机Show一下。。。
            accessories.Show();
            //输出：
            //我是iphone手机
            //对手机进行了贴膜装饰
            //对手机进行了配件装饰
        }
    }
}
