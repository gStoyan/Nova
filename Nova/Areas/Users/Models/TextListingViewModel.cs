using Nova.Services.Models;
using System.Collections.Generic;

namespace Nova.Web.Areas.User.Model
{
    public class TextListingViewModel    {
        public IEnumerable<TextListingModel> Texts {get; set; }
    }
}
