using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DemoListes
{
    public class ChuckNorrisJokeService
    {
        HttpClient client = new HttpClient();
        public async Task<ChuckNorrisJoke> GetRandomJokeAsync()
        {
            //TODO try catch
            var reponse = await client.GetStringAsync("https://api.chucknorris.io/jokes/random");
            var joke = JsonConvert.DeserializeObject<ChuckNorrisJoke>(reponse);
            return joke;
        }
    }
}
