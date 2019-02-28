using Marvin.StreamExtensions;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TwitterStreaming.GenericRootModel;

namespace TwitterStreaming.Services
{
    public class TwitterService
    {
        private readonly CancellationToken _cancellationToken;
        public string consumerKey { get; set; }
        public string consumerSecretKey { get; set; }

        private static HttpClient _httpClient = new HttpClient(
            new HttpClientHandler()
            {
                AutomaticDecompression = System.Net.DecompressionMethods.GZip
            });

        public async Task<string> GetAccessToken()
        {

            var request = new HttpRequestMessage(HttpMethod.Post, "https://api.twitter.com/oauth2/token");
            var consumerInfo = Convert.ToBase64String(new UTF8Encoding()
                                        .GetBytes(consumerKey + ":" + consumerSecretKey));
            request.Headers.Add("Authorization", "Basic " + consumerInfo);
            request.Content = new StringContent("grant_type=client_credentials",
                                                    Encoding.UTF8, "application/x-www-form-urlencoded");

            HttpResponseMessage response = await _httpClient.SendAsync(request);
            string json = await response.Content.ReadAsStringAsync();
            dynamic item = JsonConvert.DeserializeObject<object>(json);

            return item["access_token"];
        }

        public async Task<TweetRootModel> GetPopularTweets(string accessToken = null)
        {
            if (accessToken == null)
            {
                accessToken = await GetAccessToken();
            }

            var requestUsrTimeline = new HttpRequestMessage(HttpMethod.Get,
                string.Format("https://api.twitter.com/1.1/search/tweets.json?q=nasa&count=25"));

            requestUsrTimeline.Headers.Add("Authorization", "Bearer " + accessToken);
            requestUsrTimeline.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            requestUsrTimeline.Headers.AcceptEncoding.Add(new StringWithQualityHeaderValue("gzip"));
            using (var responseUserTimeLine = await _httpClient.SendAsync(requestUsrTimeline,
                 HttpCompletionOption.ResponseHeadersRead))
            {
                responseUserTimeLine.EnsureSuccessStatusCode();
                var stream = await responseUserTimeLine.Content.ReadAsStreamAsync();
                var tweets = stream.ReadAndDeserializeFromJson<TweetRootModel>();
                //var contentBody = await responseUserTimeLine.Content.ReadAsStringAsync();
                //TweetRootModel tweets = JsonConvert.DeserializeObject<TweetRootModel>(contentBody);
                return tweets;
            }
        }

    }
}
