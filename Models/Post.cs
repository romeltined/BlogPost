using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BlogPost.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        [JsonIgnore]
        public int BlogId { get; set; }

        [JsonIgnore]
        public virtual Blog Blog { get; set; }
    }
}
