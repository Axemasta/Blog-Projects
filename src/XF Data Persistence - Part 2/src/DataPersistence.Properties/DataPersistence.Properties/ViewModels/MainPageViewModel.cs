using System;
using System.ComponentModel;
using System.Windows.Input;

using Xamarin.Forms;

using DataPersistence.Properties.Settings;

namespace DataPersistence.Properties.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        #region Properties

        private IAppSettings _appSettings;

        public ICommand GetValueCommand { get; private set; }
        public ICommand UpdateValueCommand { get; private set; }

        private string _redirectUrl;
        public string RedirectUrl
        {
            get => _redirectUrl;
        }

        private string _updatedValue;
        public string UpdatedValue
        {
            get
            {
                return _updatedValue;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _updatedValue = value;
                }
            }
        }

        #endregion Properties

        public MainPageViewModel()
        {
            _appSettings = new AppSettings();

            GetValueCommand = new Command(OnGetValue);
            UpdateValueCommand = new Command(OnUpdateValue);

            _redirectUrl = "Press to get redirect url";
        }

        #region OnCommand Methods

        private void OnGetValue()
        {
            _redirectUrl = _appSettings.RedirectUrl;

            OnPropertyChanged(nameof(RedirectUrl));
        }

        private void OnUpdateValue()
        {
            if (_appSettings.RedirectUrl != _updatedValue)
            {
                _appSettings.RedirectUrl = _updatedValue;
            }
        }

        #endregion OnCommand Methods

        #region PropertyChanged Methods

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion PropertyChanged Methods
    }
}
