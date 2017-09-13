using StoryApp.Models;
using StoryApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StoryApp.ViewModels.Stories
{
    public class StoryDetailViewModel : BaseViewModel
    {
        public new string Title
        {
            get { return base.Title; }
            set { base.Title = value; }
        }

        private Story _Story;
        public Story Story
        {
            get { return _Story; }
            set
            {
                _Story = value;
                OnPropertyChanged("Story");
            }
        }

        public StoryDetailViewModel(Story storyDetail)
        {
            _Story = storyDetail;
            Title = _Story.Title;
        }

        Command _SaveStoryCommand;

        /// <summary>
        /// Command to load accounts
        /// </summary>
        public Command SaveStoryCommand
        {
            get
            {
                return _SaveStoryCommand ?? (_SaveStoryCommand = new Command(ExecuteSaveStoryCommandAsync));
            }
        }

         void  ExecuteSaveStoryCommandAsync()
        {
            if (IsBusy)
                return;

            IsBusy = true;
            SaveStoryCommand.ChangeCanExecute();

            //if (_Story.Id<=0)
            //{
            //     _StoryRepo.Insert(_Story);
            //}
            //else
            //{
            //     _StoryRepo.Update(_Story);
            //}

            IsBusy = false;
            SaveStoryCommand.ChangeCanExecute();
        }
    }
}