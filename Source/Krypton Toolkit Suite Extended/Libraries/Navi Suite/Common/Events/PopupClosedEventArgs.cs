﻿using System;

namespace Krypton.Toolkit.Extended.Navi.Suite
{
    /// <summary>
    /// Contains event information for a <see cref="PopupClosed"/> event.
    /// </summary>
    public class PopupClosedEventArgs : EventArgs
    {
        /// <summary>
        /// The popup form.
        /// </summary>
        private KryptonForm popup = null;

        /// <summary>
        /// Gets the popup form which is being closed.
        /// </summary>
        public KryptonForm Popup
        {
            get { return popup; }
        }

        /// <summary>
        /// Constructs a new instance of this class for the specified
        /// popup form.
        /// </summary>
        /// <param name="popup">Popup Form which is being closed.</param>
        public PopupClosedEventArgs(KryptonForm popup)
        {
            this.popup = popup;
        }
    }

    /// <summary>
    /// Represents the method which responds to a <see cref="PopupClosed"/> event.
    /// </summary>
    public delegate void PopupClosedEventHandler(object sender, PopupClosedEventArgs e);
}