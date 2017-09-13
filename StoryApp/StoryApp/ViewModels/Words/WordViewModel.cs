using StoryApp.Models;
using StoryApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StoryApp.ViewModels.Words
{
    public class WordViewModel: BaseViewModel
    {

        public new string Title
        {
            get { return base.Title; }
            set { base.Title = value; }
        }

        private Word _Word;

        public WordViewModel(Word _wordDetail)
        {
            _Word = _wordDetail;
            this.Title = _wordDetail.BaseWord;
        }

        public Word Word
        {
            get { return _Word; }
            set
            {
                _Word = value;
                OnPropertyChanged("Word");
            }
        }
    }
}
