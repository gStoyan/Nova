using Nova.Data.Models;
using Nova.Core.Mapping;
using AutoMapper;
using System.Collections.Generic;

namespace Nova.Services.Model
{
    public class NovaModelListingModel : IMapFrom<NovaModel>, IHaveCustomMapping
    {
       
        public int Id { get; set; }

       
        public string Name { get; set; }

       public string AttackPoints { get; set; }

        
        public string ArmorPoints { get; set; }

        public string HealethPoints { get; set; }

        public List<Army> Armies { get; set; }
        public void ConfigureMapping(Profile mapper)
        {
            mapper.CreateMap<NovaModel, NovaModelListingModel>();
        }
    }
}
