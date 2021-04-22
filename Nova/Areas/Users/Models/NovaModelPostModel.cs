using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nova.Web.Areas.Users.Models
{
    public class NovaModelPostModel
    {
        
     
        public string Name { get; set; }

        public int AttackPoints { get; set; }

        public int ArmorPoints { get; set; }

        public int HealthPoints { get; set; }

        public int Range { get; set; }
    }
}
