using HandsOnTest.DataAccess.Repository.Contracts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTest.DataAccess.Repository
{
    public class BaseRepository: IBaseRepository
    {
        private Uri _baseUrl;

        public BaseRepository()
        {
            _baseUrl = new Uri("http://masglobaltestapi.azurewebsites.net/api/");
        }

        public async Task<T> GetAsync<T>(string target)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = _baseUrl;
                client.Timeout = new TimeSpan(1, 0, 0);
                var response = await client.GetAsync(target);

                if (!response.IsSuccessStatusCode)
                {
                    //Log
                    return default(T);
                }

                var responseString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                var responseObj = JsonConvert.DeserializeObject<T>(responseString);

                return responseObj;
            }
        }
    }
}
