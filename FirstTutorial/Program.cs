using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FirstTutorial
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var url = args[0];


            using (var httpClient = new HttpClient())
            {
                HttpResponseMessage response = await httpClient.GetAsync(url);


                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();

                    var regex = new Regex("[a-z]+[a-z0-9-]*@[a-z-]+\\.[a-z]+", RegexOptions.IgnoreCase);

                    var emailAddresses = regex.Matches(content);

                    foreach (var match in emailAddresses)
                    {
                        Console.WriteLine(match.ToString());
                    }
                }

            }

        }
    }
}
