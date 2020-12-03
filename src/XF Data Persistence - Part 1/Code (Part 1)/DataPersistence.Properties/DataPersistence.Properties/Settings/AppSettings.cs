using System;
using System.Collections.Generic;
using System.Text;

using Plugin.Settings.Abstractions;
using Plugin.Settings;

namespace DataPersistence.Properties.Settings
{
    class AppSettings : IAppSettings
    {
        /// <summary>
        /// App Settings Connection.
        /// </summary>
        private static ISettings _appSettings => CrossSettings.Current;

        #region Redirect URL

        private static readonly string RedirectUrlKey = SettingsConstants.RedirectUrlKey;
        private static readonly string RedirectUrlDefault = SettingsConstants.RedirectUrlDefault;

        /// <summary>
        /// Gets or Sets the Server Redirect URL
        /// </summary>
        public string RedirectUrl
        {
            get
            {
                return _appSettings.GetValueOrDefault(RedirectUrlKey, RedirectUrlDefault);
            }
            set
            {
                _appSettings.AddOrUpdateValue(RedirectUrlKey, value);
            }
        }

        #endregion Redirect URL 
    }
}