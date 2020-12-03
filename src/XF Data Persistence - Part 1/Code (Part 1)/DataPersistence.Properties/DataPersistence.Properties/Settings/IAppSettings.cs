using System;
using System.Collections.Generic;
using System.Text;

namespace DataPersistence.Properties.Settings
{
    interface IAppSettings
    {
        /// <summary>
        /// Gets or Sets the Server Redirect URL
        /// </summary>
        string RedirectUrl { get; set; }
    }
}