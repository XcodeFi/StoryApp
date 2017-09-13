using StoryApp.Models;
using StoryApp.Services.Base;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryApp.Services
{
    public class WordRepo : LocalRepo<Word>
    {
        public WordRepo() : base(App.DbConnectionAsync, App.DbConnection)
        {

        }
    }
}