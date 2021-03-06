﻿using System;

namespace Krypton.Toolkit.Extended.Software.Updater.NetSparkle
{
    /// <summary>
    /// Interface for UIs that tell the user that NetSparkle is checking for updates
    /// </summary>
    public interface ICheckingForUpdates
    {
        /// <summary>
        /// Event to fire when the checking for updates UI is closing
        /// </summary>
        event EventHandler UpdatesUIClosing;

        /// <summary>
        /// Show the UI
        /// </summary>
        void Show();

        /// <summary>
        /// Close the form
        /// </summary>
        void Close();
    }
}