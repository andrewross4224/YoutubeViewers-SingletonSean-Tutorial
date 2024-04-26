using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeViewers.WPF.Models;
using YoutubeViewers.WPF.Stores;

namespace YoutubeViewers.WPF.ViewModels
{
    public class YoutubeViewersDetailsViewModel : ViewModelBase
    {
        private readonly SelectedYoutubeViewerStore _selectedYoutubeViewerStore;

        private YoutubeViewer SelectedYoutubeViewer => _selectedYoutubeViewerStore.SelectedYoutubeViewer;

        public bool HasSelectedYoutubeViewer => SelectedYoutubeViewer != null;
        public string Username => SelectedYoutubeViewer?.Username ?? "Unknown";
        public string IsSubscribedDisplay => (SelectedYoutubeViewer?.IsSubscribed ?? false) ? "Yes" : "No";
        public string IsMemberDisplay => (SelectedYoutubeViewer?.IsMember ?? false) ? "Yes" : "No";

        public YoutubeViewersDetailsViewModel(SelectedYoutubeViewerStore selectedYoutubeViewerStore)
        {
            _selectedYoutubeViewerStore = selectedYoutubeViewerStore;

            _selectedYoutubeViewerStore.SelectedYoutubeViewerChanged += _selectedYoutubeViewerStore_SelectedYoutubeViewerChanged;
        }

        protected override void Dispose()
        {
            _selectedYoutubeViewerStore.SelectedYoutubeViewerChanged -= _selectedYoutubeViewerStore_SelectedYoutubeViewerChanged;
            base.Dispose();
        }
        private void _selectedYoutubeViewerStore_SelectedYoutubeViewerChanged()
        {
            onPropertyChanged(nameof(HasSelectedYoutubeViewer));
            onPropertyChanged(nameof(Username));
            onPropertyChanged(nameof(IsSubscribedDisplay));
            onPropertyChanged(nameof(IsMemberDisplay));
        }
    }
}
