using Nova.Data.Models;
using Nova.Core.Mapping;
using AutoMapper;

namespace Nova.Services.Models
{
    public class TextListingModel:IMapFrom<Text> , IHaveCustomMapping
    {        
        public int Id { get; set; }        
        public string Title { get; set; }        
        public string Content { get; set; }

        public void ConfigureMapping(Profile mapper)
        {
            mapper.CreateMap<Text, TextListingModel>();
        }
    }
}
