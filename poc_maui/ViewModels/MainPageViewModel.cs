using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;
using poc_maui.Models;

namespace poc_maui.ViewModels
{
	public class MainPageViewModel : BaseViewModel
	{
        #region Constructor
        public MainPageViewModel()
		{
           
        }

        #endregion

        #region Private Properties

        private DateTime? _correctDate = null;

        #endregion

        #region Public Properties

        public DateTime? CorrectDate
        {
            get { return _correctDate; }
            set { _correctDate = value; OnPropertyChanged(nameof(CorrectDate)); }
        }

        #endregion
       
    }
}

