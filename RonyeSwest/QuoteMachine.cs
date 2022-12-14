using Newtonsoft.Json.Linq;

namespace RonyeSwest
{
    public class QuoteMachine
    {
        public static void YeQuote()
        {
            var client = new HttpClient();

            //var kanyeURL = "https://api.kanye.rest";

            var kanyeResponse = client.GetStringAsync("https://api.kanye.rest").Result;

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            Console.WriteLine($"Ye: {kanyeQuote}\n");

        }

        public static void RonQuote()
        {
            var client = new HttpClient();

            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronResponse = client.GetStringAsync(ronURL).Result;

            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace('\"', ' ').Replace(']', ' ').Trim();

            Console.WriteLine($"Ron: {ronQuote}\n");

        }
    }
}