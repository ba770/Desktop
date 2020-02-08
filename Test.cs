using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CsharpConsoleApplication
{
    public delegate void MyDelegate(string str);//声明一个没有参数没有返回值的委托函数
    class Test
    {
        static void Main(string[] args)
        {
            HandleStr("hello world", StrToUppper);
            HandleStr("HELLO WORLD", StrToLower);
            System.Console.ReadLine();
        }

        static void HandleStr(string str, MyDelegate del)//委托作函数参数，有点多态的意识
        {
            del(str);//委托的调用
        }
        static void StrToUppper(string str)//将字符串转成大小
        {
            str = str.ToUpper();
            System.Console.WriteLine(str);
        }

        static void StrToLower(string str)//将字符串转成小写
        {
            str = str.ToLower();
            System.Console.WriteLine(str);
        }

    }

}