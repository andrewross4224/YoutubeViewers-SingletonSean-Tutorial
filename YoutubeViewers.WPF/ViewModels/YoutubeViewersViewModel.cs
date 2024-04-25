using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using YoutubeViewers.WPF.Stores;

namespace YoutubeViewers.WPF.ViewModels
{
    class YoutubeViewersViewModel : ViewModelBase
    {
        public YoutubeViewersListingViewModel YoutubeViewersListingViewModel { get; }
        public YoutubeViewersDetailsViewModel YoutubeViewersDetailsViewModel { get; }
        public ICommand AddYoutubeViewersCommand { get; }

        public YoutubeViewersViewModel(SelectedYoutubeViewerStore _selectedYoutubeViewerStore)
        {
            YoutubeViewersListingViewModel = new YoutubeViewersListingViewModel(_selectedYoutubeViewerStore);

            YoutubeViewersDetailsViewModel = new YoutubeViewersDetailsViewModel(_selectedYoutubeViewerStore);
        }
    }
}
