using System;

namespace DependencyInjection_AutoFac
{
    public class SomeService : ISomeService
    {
        public void SayHi()
        {
            System.Console.WriteLine("Hi");;
        }
    }
}