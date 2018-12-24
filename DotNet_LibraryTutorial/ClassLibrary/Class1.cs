using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// MyClass class 類別
    /// </summary>
    public class MyClass
    {
        /// <summary>
        /// MyClass的一個public property型態為public
        /// </summary>
        public string MyName { get; set; }
        /// <summary>
        /// MyClass傳入一個string參數的建構子 (constructor)
        /// </summary>
        /// <param name="name"></param>
        public MyClass(string name)
        {
            //建構時，需傳入一個string參數，並將所傳入參數存給MyName
            //this表示建構出此物件時的實際Instance
            this.MyName = name;
        }
        /// <summary>
        /// 於終端機輸出 "SayHello" from MyClass 文字
        /// </summary>
        public void SayHello()
        {
            Console.WriteLine("\"SayHello\" from MyClass");
        }
    }
}
