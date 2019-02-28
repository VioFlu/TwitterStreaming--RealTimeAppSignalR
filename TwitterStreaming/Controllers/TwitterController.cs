using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;
using TwitterStreaming.Models;
using TwitterStreaming.Services;

namespace TwitterStreaming.Controllers
{
    [Route("api/[Controller]")]
    public class TwitterController : Controller
    {
        private readonly TwitterService _twitterService;
        private readonly IMapper _mapper;
        public TwitterController(TwitterService twitterService, IConfiguration configuration, IMapper mapper)
        {
            _twitterService = twitterService;
            _twitterService.consumerKey = configuration["TwitterKeys:consumerKey"];
            _twitterService.consumerSecretKey = configuration["TwitterKeys:consumerSecretKey"];
            _mapper = mapper;
        }
        //[Route("/api/[Controller]/UsersTwitter")
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var popularTweets = await _twitterService.GetPopularTweets();
            var tweets = _mapper.Map<IEnumerable<TweetViewModel>>(popularTweets.statuses);
            return Ok(tweets);
        }
    }
}