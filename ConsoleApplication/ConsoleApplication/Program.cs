using System;
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
            Console.WriteLine("MY first git change I want to merge");



            try
            {
                // do some operation that can fail

                DoBadWork();
                //double result = x / y;
            }
            catch (Exception ex)
            {
                // do some local cleanup
                //throw ex;
                throw new ApplicationException("fatal error", ex);
            }
        }

        public void DoAnotherWork()
        {
            Console.WriteLine("This is another work...");
        }

        public void NewMethod(string testparameter)
        {
            throw new NotImplementedException();
        }
    }
}
