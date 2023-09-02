using System;
using System.Threading.Tasks;
using System.Net.Http;
namespace lab_dotnet
{
    class AsyncProgram
    {
        public async Task<int> GetUrlContentLengthAsync(string url)
        {
            Console.WriteLine($"Connecting to {url} and fetching the contents..");
            var client = new HttpClient();
            Task<string> getStringTask = client.GetStringAsync(url);
            DoIndependentWork();
            string contents = await getStringTask;
            Console.WriteLine("Fetching completed !");
            return contents.Length;

        }
        void DoIndependentWork()
        {

            Console.WriteLine("Working..");
            Console.WriteLine("Completed.");
        }
        static void Main(string[] args)
        {
            AsyncProgram ap = new AsyncProgram();
            Task<int> result = ap.GetUrlContentLengthAsync("https://thecipherbit.me");
            Console.WriteLine("Length of the contents : {0}", result.Result);
            Console.WriteLine("Lab No.: 18  Roll no: 23957 \n Name:Bibek Angdembe");
        }
    }

}