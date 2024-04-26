using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using YoutubeViewers.WPF.Commands;
using YoutubeViewers.WPF.Models;
using YoutubeViewers.WPF.Stores;

namespace YoutubeViewers.WPF.ViewModels
{
    public class YoutubeViewersListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<YoutubeViewersListingItemViewModel> _youtubeViewersListingItemViewModels;
        private readonly SelectedYoutubeViewerStore _selectedYoutubeViewerStore;

        public IEnumerable<YoutubeViewersListingItemViewModel> YoutubeViewersListingItemViewModels => _youtubeViewersListingItemViewModels;

        private YoutubeViewersListingItemViewModel _selectedYoutubeViewerListingItemViewModel;
        public YoutubeViewersListingItemViewModel SelectedYoutubeViewerListingItemViewModel
        {
            get
            {
                return _selectedYoutubeViewerListingItemViewModel;
            }
            set
            {
                _selectedYoutubeViewerListingItemViewModel = value;
                onPropertyChanged(nameof(SelectedYoutubeViewerListingItemViewModel));
                _selectedYoutubeViewerStore.SelectedYoutubeViewer = _selectedYoutubeViewerListingItemViewModel?.YoutubeViewer;
            }
        }

        public YoutubeViewersListingViewModel(SelectedYoutubeViewerStore selectedYoutubeViewerStore, ModalNavigationStore modalNavigationStore)
        {
            _selectedYoutubeViewerStore = selectedYoutubeViewerStore;
            _youtubeViewersListingItemViewModels = new ObservableCollection<YoutubeViewersListingItemViewModel>();

            AddYoutubeViewer(new YoutubeViewer("Mary", true, false), modalNavigationStore);
            AddYoutubeViewer(new YoutubeViewer("Andrew", false, false), modalNavigationStore);
            AddYoutubeViewer(new YoutubeViewer("Dylan", true, true), modalNavigationStore);
        }

        private void AddYoutubeViewer(YoutubeViewer youtubeViewer, ModalNavigationStore modalNavigationStore) 
        {
            ICommand editCommand = new OpenEditYoutubeViewerCommand(youtubeViewer, modalNavigationStore);
            _youtubeViewersListingItemViewModels.Add(new YoutubeViewersListingItemViewModel(youtubeViewer, editCommand));
        }
    }
}
