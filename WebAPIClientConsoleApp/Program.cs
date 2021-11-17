using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;



namespace WebAPIClientConsoleApp
{
    internal class Program
    {

        private static readonly HttpClient client = new HttpClient();
        static Task Main(string[] args)
        {
            return Task.CompletedTask;
        }
    }
}



