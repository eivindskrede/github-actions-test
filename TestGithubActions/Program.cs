using System;

namespace TestGithubActions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Don't tell anybody, but {Environment.GetEnvironemntVariable("env_secret")}");
        }
    }
}
