using System;
using System.Threading;

namespace BeerStore.Services
{
	public class Service
	{
        // HttpClient is intended to be instantiated once per application, rather than per-use. See Remarks.
        static readonly HttpClient client = new HttpClient();

        // Call asynchronous network methods in a try/catch block to handle exceptions.
        public static async Task<string> GetResponse(string url)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("http://www.contoso.com/");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);

                return responseBody;
            }
            catch (HttpRequestException e)
            {
              

              string exceptionMessage = String.Format("Message :{0}", e.Message);
              return exceptionMessage;
                

            }
        }


        public async static Task GetStringTestAsync()
        {
            Service s = new Service();

            await s.First();
            

            await s.Second();
            

            await s.Third();
            

        }

        private async Task First()
        {
            await Task.Delay(2000);
            Console.WriteLine("First");

        }

        private async Task Second()
        {
            await Task.Delay(2000);
            Console.WriteLine("Second");
        }

        private async Task Third()
        {
            await Task.Delay(2000);
            Console.WriteLine("Third");
        }
        
    }
}

