using StoryApp.Extentions;
using StoryApp.Models;
using StoryApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StoryApp.ViewModels.Words
{
    public class ListWordViewModel : BaseViewModel
    {

        public new string Title
        {
            get { return base.Title ?? "Danh sách truyện chêm"; }
            set { base.Title = value; }
        }

        ObservableCollection<Word> _Words;
        public ObservableCollection<Word> Words
        {
            get { return _Words; }
            set
            {
                _Words = value;
                OnPropertyChanged("Words");
            }
        }

        public bool NeedsRefresh { get; set; }

        private WordRepo _repo = null;

        public ListWordViewModel()
        {
            _Words = new ObservableCollection<Word>();

            _repo = new WordRepo();
            //_DataService = DependencyService.Get<IDataService>();
            //MessagingCenter.Subscribe<Story>(this, MessagingServiceConstants.STORY, (story) =>
            //{
            //    IsInitialized = false;
            //});
        }

        Command _LoadWordsCommand;

        /// <summary>
        /// Command to load accounts
        /// </summary>
        public Command LoadWordsCommand
        {
            get { return _LoadWordsCommand ?? (_LoadWordsCommand = new Command(ExecuteLoadWordsCommand)); }
        }

        async void ExecuteLoadWordsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;
            LoadWordsCommand.ChangeCanExecute();

            Words = _repo.Get().ToObservableCollection();

            IsBusy = false;
            LoadWordsCommand.ChangeCanExecute();
        }
    }
}
