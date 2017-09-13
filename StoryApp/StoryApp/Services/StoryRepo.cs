using StoryApp.Models;
using StoryApp.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace StoryApp.Services
{
    public class StoryRepo : LocalRepo<Story>
    {
        public StoryRepo() : base(App.DbConnectionAsync, App.DbConnection)
        {

        }
    }
}
