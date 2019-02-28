using TwitterStreaming.GenericRootModel;

namespace TwitterStreaming.Models
{
    public class TweetViewModel
    {
        public long ID { get; set; }
        public string tweetText { get; set; }
        public string usrName { get; set; }
        public Url[] tweetUrl { get; set; }
    }
}
