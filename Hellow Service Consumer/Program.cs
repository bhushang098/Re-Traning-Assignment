using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hellow_Service_Consumer.HellowServiceReference;

namespace Hellow_Service_Consumer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            HellowServiceSoapClient client = new HellowServiceSoapClient();

            Console.WriteLine(client.HelloWorld("Bhsuan Gurnule"));


        }
    }
}
