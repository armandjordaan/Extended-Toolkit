﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Krypton.Toolkit.Extended.Software.Updater.NetSparkle
{
    public class ToastNotifier : KryptonForm
    {
        #region Designer Code
        private KryptonPanel kryptonPanel1;
        private KryptonLinkLabel kllCallToAction;
        private KryptonLabel klblMessage;
        public System.Windows.Forms.PictureBox pbxIcon;
        private System.Windows.Forms.ImageList il;
        private System.ComponentModel.IContainer components;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.kllCallToAction = new Krypton.Toolkit.KryptonLinkLabel();
            this.klblMessage = new Krypton.Toolkit.KryptonLabel();
            this.pbxIcon = new System.Windows.Forms.PictureBox();
            this.il = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kllCallToAction);
            this.kryptonPanel1.Controls.Add(this.klblMessage);
            this.kryptonPanel1.Controls.Add(this.pbxIcon);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(272, 69);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kllCallToAction
            // 
            this.kllCallToAction.Location = new System.Drawing.Point(78, 42);
            this.kllCallToAction.Name = "kllCallToAction";
            this.kllCallToAction.Size = new System.Drawing.Size(110, 20);
            this.kllCallToAction.TabIndex = 1;
            this.kllCallToAction.Values.Text = "kryptonLinkLabel1";
            this.kllCallToAction.LinkClicked += new System.EventHandler(this.kllCallToAction_LinkClicked);
            // 
            // klblMessage
            // 
            this.klblMessage.Location = new System.Drawing.Point(78, 12);
            this.klblMessage.Name = "klblMessage";
            this.klblMessage.Size = new System.Drawing.Size(115, 23);
            this.klblMessage.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblMessage.TabIndex = 1;
            this.klblMessage.Values.Text = "kryptonLabel1";
            // 
            // pbxIcon
            // 
            this.pbxIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbxIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbxIcon.Location = new System.Drawing.Point(0, 0);
            this.pbxIcon.Name = "pbxIcon";
            this.pbxIcon.Size = new System.Drawing.Size(72, 69);
            this.pbxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxIcon.TabIndex = 0;
            this.pbxIcon.TabStop = false;
            // 
            // il
            // 
            this.il.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.il.ImageSize = new System.Drawing.Size(16, 16);
            this.il.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ToastNotifier
            // 
            this.ClientSize = new System.Drawing.Size(272, 69);
            this.ControlBox = false;
            this.Controls.Add(this.kryptonPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ToastNotifier";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.ToastNotifier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcon)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private Timer _goUpTimer;
        private Timer _goDownTimer;
        private Timer _pauseTimer;
        private int startPosX;
        private int startPosY;

        public ToastNotifier(Icon applicationIcon = null)
        {
            InitializeComponent();
            // We want our window to be the top most
            TopMost = true;
            // Pop doesn't need to be shown in task bar
            ShowInTaskbar = false;
            // Create and run timer for animation
            _goUpTimer = new Timer();
            _goUpTimer.Interval = 25;
            _goUpTimer.Tick += GoUpTimerTick;
            _goDownTimer = new Timer();
            _goDownTimer.Interval = 25;
            _goDownTimer.Tick += GoDownTimerTick;
            _pauseTimer = new Timer();
            _pauseTimer.Interval = 15000;
            _pauseTimer.Tick += PauseTimer_Tick;

            if (applicationIcon != null)
            {
                Icon = applicationIcon;
                pbxIcon.Image = new Icon(applicationIcon, new Size(48, 48)).ToBitmap();
            }
        }

        public Action<List<AppCastItem>> ClickAction { get; set; }

        public List<AppCastItem> Updates { get; set; }

        private void PauseTimer_Tick(object sender, EventArgs e)
        {
            _pauseTimer.Stop();
            _goDownTimer.Start();
        }

        private void ToastNotifier_Load(object sender, EventArgs e)
        {
            // Move window out of screen
            startPosX = Screen.PrimaryScreen.WorkingArea.Width - Width;
            startPosY = Screen.PrimaryScreen.WorkingArea.Height;
            SetDesktopLocation(startPosX, startPosY);
            // Begin animation
            _goUpTimer.Start();
        }

        void GoUpTimerTick(object sender, EventArgs e)
        {
            //Lift window by 5 pixels
            startPosY -= 5;
            //If window is fully visible stop the timer
            if (startPosY < Screen.PrimaryScreen.WorkingArea.Height - Height)
            {
                _goUpTimer.Stop();
                _pauseTimer.Start();
            }
            else
            {
                SetDesktopLocation(startPosX, startPosY);
            }
        }

        private void GoDownTimerTick(object sender, EventArgs e)
        {
            //Lower window by 5 pixels
            startPosY += 5;
            //If window is fully visible stop the timer
            if (startPosY > Screen.PrimaryScreen.WorkingArea.Height)
            {
                _goDownTimer.Stop();
                Close();
            }
            else
            {
                SetDesktopLocation(startPosX, startPosY);
            }
        }

        private void ToastNotifier_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            ClickAction?.Invoke(Updates);
            Close();
        }

        /// <summary>
        /// Show the toast
        /// </summary>
        /// <param name="message">Main message of the toast</param>
        /// <param name="callToAction">Text of the hyperlink</param>
        /// <param name="seconds">How long to show before it goes back down</param>
        public void Show(string message, string callToAction, int seconds)
        {
            klblMessage.Text = message;
            kllCallToAction.Text = callToAction;
            _pauseTimer.Interval = 1000 * seconds;
            Show();
        }

        private void kllCallToAction_LinkClicked(object sender, EventArgs e)
        {
            ToastNotifier_Click(null, null);
        }
    }
}