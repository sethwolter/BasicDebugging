using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugClassDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            while ( num <= 3)

            Debug.WriteLine("Hold onto your hats...Debugging is about to begin");
            Debug.Indent();

            Debug.WriteLine("Welcome to the random number input machine");
            Debug.WriteLine("");
            Debug.WriteLine("With this product you will be able to input 3 numbers!");
            Debug.WriteLine("");
            Debug.WriteLine("Please input a number:  ");
            Debug.WriteLine("");
            num = Convert.ToInt32(Console.ReadLine());
            Debug.WriteLine("");

            Debug.WriteLineIf(num > 0, "This message WILL appear");
            Debug.WriteLineIf(num < 4, "This message will NOT appear");

            Debug.Assert(num > 1, "Message will NOT appear");
            Debug.Assert(num < 1, "Message will appear");

            TextWriterTraceListener tr1 = new TextWriterTraceListener(System.Console.Out);
            Debug.Listeners.Add(tr1);
            TextWriterTraceListener tr2 = new TextWriterTraceListener(System.IO.File.CreateText("Output.txt"));
            Debug.Listeners.Add(tr2);

            Debug.Unindent();
            Debug.WriteLine("Debugging ended... thanks for playing....");

            Debug.Flush();
            Console.ReadKey();

            num++;

        }
    }
}
