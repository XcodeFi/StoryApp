using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryApp.Models
{
    public class Word:BaseModel
    {
        //từ
        public string BaseWord { get; set; }

        //nghĩa của từ
        public string Meaning { get; set; }
        //cách phát âm
        public string Enunciate { get; set; }
    }
}
