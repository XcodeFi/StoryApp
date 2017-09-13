using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryApp.Models
{
    public class Story:BaseModel
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public int Likes { get; set; }
        public float Rates { get; set; }
    }
}
