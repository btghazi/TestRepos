﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        public static void DoBadWork()
        {
            int x = 10;
            int y = 0;

            var result = x / y;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("MY first git change");
            Console.WriteLine("MY first git change I wnat to commit ...");



            try
            {
                // do some operation that can fail

                DoBadWork();
                //double result = x / y;
            }
            catch (Exception ex)
            {
                //throw ex;
                throw new ApplicationException("fatal error", ex);
            }
        }
    }
}
