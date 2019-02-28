using AutoMapper;
using TwitterStreaming.GenericRootModel;

namespace TwitterStreaming.Models
{
    public class TweetMappingProfile : Profile
    {
        public TweetMappingProfile()
        {
            CreateMap<Status, TweetViewModel>()
                    .ForMember(c => c.ID, opt => opt.MapFrom(tm => tm.id))
                    .ForMember(c => c.tweetText, opt => opt.MapFrom(tm => tm.text))
                    .ForMember(c => c.usrName, opt => opt.MapFrom(tm => tm.user.name))
                    .ForMember(c => c.tweetUrl, opt => opt.MapFrom(tm => tm.entities.urls))
                    .ReverseMap();
        }
    }
}
