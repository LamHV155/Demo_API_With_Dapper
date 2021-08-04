using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace azicloud.wiki.Dtos
{
    public class GetWikiCategoriesDto
    {
        public long id { get; set; }
        public long parent_id { get; set; }
        public long image_id { get; set; }
        public bool active { get; set; }
        public bool deleted { get; set; }
        public long delete_uid { get; set; }
        public DateTime? delete_date { get; set; }
        public long write_uid { get; set; }
        public DateTime? write_date { get; set; }
        public long create_uid { get; set; }
        public DateTime create_date { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }
}
