using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;

namespace BarcodeScanningPrism.ViewModels
{
    public class ScannerPageViewModel : ViewModelBase
    {
        #region Properties

        #region - Interfaces

        private readonly INavigationService _navigationService;
        private readonly IPageDialogService _pageDialogue;
        private readonly IDeviceService _deviceService;

        #endregion - Interfaces

        #region - Delegate Commands

        public DelegateCommand OnBarcodeScannedCommand { get; set; }

        #endregion - Delegate Commands

        #region - Properties

        //Used in OnBarcodeScanned();
        bool _isProcessing = false;

        private bool _isAnalyzing = true;
        public bool IsAnalyzing
        {
            get
            {
                return _isAnalyzing;
            }
            set
            {
                if (SetProperty(ref _isAnalyzing, value))
                {
                    //Do something
                }
            }
        }

        private bool _isScanning;
        public bool IsScanning
        {
            get
            {
                return _isScanning;
            }
            set
            {
                if (SetProperty(ref _isScanning, value))
                {
                    //Do something
                }
            }
        }

        private ZXing.Result _result;
        public ZXing.Result Result
        {
            get
            {
                return _result;
            }
            set
            {
                if (SetProperty(ref _result, value))
                {
                    //Do something
                }
            }
        }

        #endregion - Properties

        #endregion Properties

        public ScannerPageViewModel(INavigationService navigationService, 
                                    IPageDialogService pageDialogService,
                                    IDeviceService deviceService) : base(navigationService)
        {
            Title = "Scan";

            _navigationService = navigationService;
            _pageDialogue = pageDialogService;
            _deviceService = deviceService;

            OnBarcodeScannedCommand = new DelegateCommand(OnBarcodeScanned);

            _isScanning = true;
            _isAnalyzing = true;

            RaisePropertyChanged("IsScanning");
            RaisePropertyChanged("IsAnalyzing");
        }

        private void OnBarcodeScanned()
        {
            if (!_isProcessing)
            {
                _deviceService.BeginInvokeOnMainThread(async () =>
                {
                    _isProcessing = true;
                    _isAnalyzing = false;
                    RaisePropertyChanged("IsAnalyzing");

                    string message = String.Format("I read a barcode and found the value: {0}", Result.Text);

                    Debug.WriteLine(message);

                    await _pageDialogue.DisplayAlertAsync("Scan!", message, "Good for you");

                    _isProcessing = false;
                    _isAnalyzing = true;
                    RaisePropertyChanged("IsAnalyzing");
                });
            }
        }
    }
}
