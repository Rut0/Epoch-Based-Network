using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpochClient
{
    class Program
    {
        private static EpochClient client;
        static void Main(string[] args)
        {
            client = new EpochClient("127.0.0.1");
            client.DataReceived += Client_DataReceived;
            string input = "";
            while (!string.IsNullOrEmpty((input = Console.ReadLine())))
            {
                client.Write(input.Trim());
            }
        }

        private static void Client_DataReceived(string str)
        {
            Console.WriteLine("RECEIVED: " + str);
        }
    }
}
