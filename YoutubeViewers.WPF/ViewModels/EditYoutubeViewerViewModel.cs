using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeViewers.WPF.ViewModels
{
    public class EditYoutubeViewerViewModel
    {
        public YoutubeViewerDetailsFormViewModel YoutubeViewerDetailsFormViewModel { get; }

        public EditYoutubeViewerViewModel()
        {
            YoutubeViewerDetailsFormViewModel = new YoutubeViewerDetailsFormViewModel();
        }
    }
}
