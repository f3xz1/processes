using System;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Threading;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1  
            Process process1 = new Process();
            process1.StartInfo.FileName = "notepad.exe";
            process1.Start();
            process1.WaitForExit();
            Console.WriteLine(process1.StartInfo.FileName + " died");



            //2
            Process process2 = new Process();
            process2.StartInfo.FileName = "notepad.exe";

            process2.Start();
            Console.WriteLine("End the process?(y/n)");
            string? yesno = Console.ReadLine();
            if (yesno == "y")
            {
                process2.Kill();
            }
            else
            {
                process2.WaitForExit();
            }
            Console.WriteLine(process2.StartInfo.FileName + " died");
        }
    }
}

 


/*
clr - common language runtime
ill
bsl
jit- just in time
(встроенные) делегты 
static, dynamic  polymorphism
prop
cts
solid
Контейнеризация 
 
 
 
 */
