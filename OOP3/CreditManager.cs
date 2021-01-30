using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface ICreditManager //birisi bu interfaceyi kullanırsa alttaki metotu içermek zorunda, interfaceler I harfi ile başlar ve tanımlanır
                             //genellikle operasyonel işlemlerde kullanılır
    {
        void Calculate();
        void DoSomething();

    }
}
