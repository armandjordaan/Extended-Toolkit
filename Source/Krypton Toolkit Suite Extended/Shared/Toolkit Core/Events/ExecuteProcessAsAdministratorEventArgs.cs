﻿using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Security.Principal;
using System.Windows.Forms;

namespace Krypton.Toolkit.Extended.Core
{
    public class ExecuteProcessAsAdministratorEventArgs : EventArgs
    {
        /// <summary>Gets or sets the process path.</summary>
        /// <value>The process path.</value>
        public string ProcessPath { get; set; }

        /// <summary>Initializes a new instance of the <see cref="ExecuteProcessAsAdministratorEventArgs"/> class.</summary>
        /// <param name="processPath">The process path.</param>
        public ExecuteProcessAsAdministratorEventArgs(string processPath)
        {
            ProcessPath = processPath;

            ElevateProcessWithAdministrativeRights(ProcessPath);
        }

        /// <summary>Elevates the process with administrative rights.</summary>
        /// <param name="processName">Name of the process.</param>
        /// <exception cref="ArgumentNullException"></exception>
        private void ElevateProcessWithAdministrativeRights(string processName)
        {
            WindowsPrincipal principal = new WindowsPrincipal(WindowsIdentity.GetCurrent());

            bool hasAdministrativeRights = principal.IsInRole(WindowsBuiltInRole.Administrator);

            if (string.IsNullOrEmpty(processName)) throw new ArgumentNullException();

            if (!hasAdministrativeRights)
            {
                ProcessStartInfo process = new ProcessStartInfo();

                process.Verb = "runas";

                process.FileName = processName;

                try
                {
                    Process.Start(process);
                }
                catch (Win32Exception e)
                {
                    CoreInternalKryptonMessageBoxExtended.Show($"Error: { e.Message }", "An Error has Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return;
            }
        }
    }
}