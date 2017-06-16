using System;
using System.Net.Http;

namespace bootcamp_core_loadtester
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing load ...");

            HttpClient c = new HttpClient();

            for(int i = 0; i < 2000; i++)
            {
                var result = c.GetStringAsync("https://<enter your service>/api/products").Result; 
                Console.WriteLine("calling API");
                
                System.Threading.Thread.Sleep(200);
            }   

            Console.WriteLine("done calling API");
        
        }
    }
}
