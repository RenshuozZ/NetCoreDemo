using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    /// <summary>
    /// 工厂接口
    /// </summary>
    interface IFactory
    {
        Pizza CreatePizza();
    }
}
