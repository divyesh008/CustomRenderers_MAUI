using System;
using poc_maui.ViewModels;

namespace poc_maui.Models
{
	public class TabViewModel : BaseViewModel
	{
        //public int TabId { get; set; }
        //public string TabTitle { get; set; }
        //public bool IsSelected { get; set; }


        private bool _IsSelected;
        public bool IsSelected
        {
            get { return _IsSelected; }
            set
            {
                _IsSelected = value;
                OnPropertyChanged(nameof(IsSelected));
            }
        }

        private int _TabId;
        public int TabId
        {
            get { return _TabId; }
            set
            {
                _TabId = value;
                OnPropertyChanged(nameof(TabId));
            }
        }

        private string _TabTitle;
        public string TabTitle
        {
            get { return _TabTitle; }
            set
            {
                _TabTitle = value;
                OnPropertyChanged(nameof(TabTitle));
            }
        }
    }
}

