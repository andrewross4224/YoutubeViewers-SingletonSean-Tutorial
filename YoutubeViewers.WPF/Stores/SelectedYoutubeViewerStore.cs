using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeViewers.WPF.Models;

namespace YoutubeViewers.WPF.Stores
{
    public class SelectedYoutubeViewerStore
    {
        private YoutubeViewer _selectedYoutubeViewer;

        public YoutubeViewer SelectedYoutubeViewer
        {
            get
            { 
                return _selectedYoutubeViewer; 
            }
            set
            { 
                _selectedYoutubeViewer = value; 
                SelectedYoutubeViewerChanged?.Invoke();
            }
        }

        public event Action SelectedYoutubeViewerChanged;
    }
}
