﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpochServer
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = new EpochServer();
            server.Start();
            Console.ReadLine();
        }
    }
}
