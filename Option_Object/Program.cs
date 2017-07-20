using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Option_Object
{
    class Program
    {
        static void Main(string[] args)
        {
            Option<Part> WithCircuit = Option<Part>.Some(new Part(DateTime.Now));
            Option<Part> NoCircuit = Option<Part>.None();

            /* 
             * calls opnly when theere is a curcuit installed
             * Clint is anware and not checking nulls
             * 
             */

            WithCircuit.ToList().ForEach(c => c.MarkDefective(DateTime.Now));
            NoCircuit.ToList().ForEach(nc => nc.MarkDefective(DateTime.Now));

            Console.Read();

        }
    }
}
