using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace azicloud.wiki.Dtos
{
    public class PostWikiCategoryDto
    {
        public int Id { get; set; }
        public long uId { get; set; }
        public long parent_id { get; set; }
        public long image_id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }
}
