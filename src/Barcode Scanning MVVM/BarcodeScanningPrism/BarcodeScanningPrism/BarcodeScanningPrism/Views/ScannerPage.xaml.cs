using System;
using System.Collections.Generic;

using Xamarin.Forms;

using ZXing.Net.Mobile.Forms;
using BarcodeScanningPrism.ViewModels;
using System.Diagnostics;

namespace BarcodeScanningPrism.Views
{
    public partial class ScannerPage : ContentPage
    {
        public ScannerPage()
        {
            InitializeComponent();

            scanView.Options.DelayBetweenAnalyzingFrames = 5;
            scanView.Options.DelayBetweenContinuousScans = 5;
            scanView.AutoFocus();
        }

        void Handle_FlashButtonClicked(object sender, System.EventArgs e)
        {
            scanView.IsTorchOn = !scanView.IsTorchOn;
        }

    }
}
