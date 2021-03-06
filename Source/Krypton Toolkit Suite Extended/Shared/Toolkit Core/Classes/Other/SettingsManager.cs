﻿using Krypton.Toolkit.Extended.Core.Settings;
using System.Windows.Forms;

namespace Krypton.Toolkit.Extended.Core
{
    public class SettingsManagerAlternative
    {
        #region Variables
        private CoreSettings _mySettings = new CoreSettings();
        #endregion

        #region Constructor
        public SettingsManagerAlternative()
        {

        }
        #endregion

        #region Setters & Getters
        /// <summary>
        /// Sets the UpdateInRealTime to the value of value.
        /// </summary>
        /// <param name="value">The value of value.</param>
        public void SetUpdateInRealTime(bool value)
        {
            _mySettings.UpdateInRealTime = value;
        }

        /// <summary>
        /// Gets the UpdateInRealTime value.
        /// </summary>
        /// <returns>The value of value.</returns>
        public bool GetUpdateInRealTime()
        {
            return _mySettings.UpdateInRealTime;
        }
        #endregion

        #region Methods
        public void SaveSettings(bool useDialoguePrompt = false)
        {
            if (useDialoguePrompt)
            {
                DialogResult result = KryptonMessageBox.Show("Do you want to store and save the current setting values?", "Save Settings", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _mySettings.Save();
                }
            }
            else
            {
                _mySettings.Save();
            }
        }
        #endregion
    }
}