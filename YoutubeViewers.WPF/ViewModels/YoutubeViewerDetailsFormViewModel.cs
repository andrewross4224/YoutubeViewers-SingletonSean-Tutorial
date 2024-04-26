using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace YoutubeViewers.WPF.ViewModels
{
    public class YoutubeViewerDetailsFormViewModel : ViewModelBase
    {
		private string _username;
		public string Username
		{
			get
			{
				return _username;
			}
			set
			{
				_username = value;
                onPropertyChanged(nameof(Username));
                onPropertyChanged(nameof(CanSubmit));
			}
		}

        private bool _isSubscribed;
		public bool IsSubscribed
		{
			get
			{
				return _isSubscribed;
			}
			set
			{
				_isSubscribed = value;
				onPropertyChanged(nameof(IsSubscribed));
			}
		}

		private bool _isMember;


        public bool IsMember
		{
			get
			{
				return _isMember;
			}
			set
			{
				_isMember = value;
				onPropertyChanged(nameof(IsMember));
			}
		}

		public bool CanSubmit => !string.IsNullOrEmpty(Username);

		public ICommand SubmitCommand { get; }
		public ICommand CancelCommand { get; }
        public YoutubeViewerDetailsFormViewModel(ICommand submitCommand, ICommand cancelCommand)
        {
            SubmitCommand = submitCommand;
            CancelCommand = cancelCommand;
        }
	}
}
