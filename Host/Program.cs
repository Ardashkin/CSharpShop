﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Host
{
    class Program
    {
        static void Main()
        {
            using (var host = new ServiceHost(typeof(WcfService.Service)))
            {
                host.Open();
                Console.WriteLine("Host started...");
                Console.ReadKey();
            }
        }
    }
}
