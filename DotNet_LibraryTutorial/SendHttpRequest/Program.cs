using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendHttpRequest
{
    class Program
    {
        static void Main(string[] args)
        {
            string uri = "https://stackoverflow.com/questions/7688350/c-sharp-how-to-make-a-http-call";
            //test get method
            var response = HttpUtility.HttpGet(uri);
            Console.WriteLine($"Get Response: {response}");

            //test post method
            string parameters = string.Empty;
            response = HttpUtility.HttpPost(uri, parameters);
            Console.WriteLine($"Post Response: {response}");

            Console.ReadKey();
        }
    }
}
