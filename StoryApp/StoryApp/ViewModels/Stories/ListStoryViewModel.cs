using StoryApp.Extentions;
using StoryApp.Models;
using StoryApp.Services;
using StoryApp.Statics;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using StoryApp.Extentions;

namespace StoryApp.ViewModels.Stories
{
    public class ListStoryViewModel : BaseViewModel
    {
        private StoryRepo _repo;

        public new string Title
        {
            get { return base.Title ?? "Danh sách truyện chêm"; }
            set { base.Title = value; }
        }

        ObservableCollection<Story> _Stories;
        public ObservableCollection<Story> Stories
        {
            get { return _Stories; }
            set
            {
                _Stories = value;
                OnPropertyChanged("Stories");
            }
        }



        public bool NeedsRefresh { get; set; }

        public ListStoryViewModel()
        {
            _Stories = new ObservableCollection<Story>();

            _repo = new StoryRepo();


        }

        Command _LoadStoriesCommand;

        /// <summary>
        /// Command to load accounts
        /// </summary>
        public Command LoadStoriesCommand
        {
            get
            {
                return _LoadStoriesCommand ?? (_LoadStoriesCommand = new Command(ExecuteLoadStoriesCommandAsync));
            }
        }

        void ExecuteLoadStoriesCommandAsync()
        {
            if (IsBusy)
                return;

            IsBusy = true;
            LoadStoriesCommand.ChangeCanExecute();

            Stories = _repo.Get().ToObservableCollection();

            IsBusy = false;
            LoadStoriesCommand.ChangeCanExecute();
        }
    }
}