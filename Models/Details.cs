using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPost.Models
{
    [Owned]
    public class Detail
    {
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}
