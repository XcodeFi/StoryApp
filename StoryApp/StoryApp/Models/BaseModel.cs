using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using SQLite;
using System.Threading.Tasks;

namespace StoryApp.Models
{
    // The model class files are shared between the mobile and service projects. 
    // If ITableData were compatible with PCL profile 78, the models could be in a PCL.
    public class BaseModel :  INotifyPropertyChanged

    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }

        public DateTimeOffset? CreatedAt { get; set; }

        public DateTimeOffset? UpdatedAt { get; set; }

        public bool Deleted { get; set; }

        public byte[] Version { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public BaseModel()
        {
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }
    }
}
