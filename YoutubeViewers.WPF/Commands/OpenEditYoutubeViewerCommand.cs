using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeViewers.WPF.Models;
using YoutubeViewers.WPF.Stores;
using YoutubeViewers.WPF.ViewModels;

namespace YoutubeViewers.WPF.Commands
{
    public class OpenEditYoutubeViewerCommand : CommandBase
    {
        private readonly ModalNavigationStore _modalNavigationStore;
        private readonly YoutubeViewer _youtubeViewer;

        public OpenEditYoutubeViewerCommand(YoutubeViewer youtubeViewer, ModalNavigationStore modalNavigationStore)
        {
            _modalNavigationStore = modalNavigationStore;
            _youtubeViewer = youtubeViewer;
        }

        public override void Execute(object? parameter)
        {
            EditYoutubeViewerViewModel addYoutubeViewerViewModel = new EditYoutubeViewerViewModel(_youtubeViewer, _modalNavigationStore);

            _modalNavigationStore.CurrentViewModel = addYoutubeViewerViewModel;
        }
    }
}
