// <copyright file="MainForm.cs" company="PublicDomain.is">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>
namespace ClickLog
{
    // Directives
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;
    using Gma.System.MouseKeyHook;

    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// The m global hook.
        /// </summary>
        private IKeyboardMouseEvents m_GlobalHook;

        /// <summary>
        /// The stream writer.
        /// </summary>
        private StreamWriter streamWriter = null;

        /// <summary>
        /// The count.
        /// </summary>
        private int count = 0;

        /// <summary>
        /// Gets the window from point.
        /// </summary>
        /// <returns>The from point.</returns>
        /// <param name="p">P.</param>
        [DllImport("user32.dll")]
        private static extern IntPtr WindowFromPoint(Point p);

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ClickLog.MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            this.InitializeComponent();
        }

        /// <summary>
        /// Handles the new tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnNewToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the options tool strip menu item drop down item clicked.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOptionsToolStripMenuItemDropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the free releases PublicDomain.is tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnFreeReleasesPublicDomainisToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the original thread redditcom tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOriginalThreadRedditcomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the source code githubcom tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSourceCodeGithubcomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the about tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnAboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the start stop button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnStartStopButtonClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the browse button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnBrowseButtonClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the global hook mouse down ext.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void GlobalHookMouseDownExt(object sender, MouseEventExtArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var point = new Point(e.Location.X, e.Location.Y);

                IntPtr windowHandle = WindowFromPoint(point);

                // Write if not the start/stop button
                if (this.startStopButton.Handle != windowHandle)
                {
                    // Add line to stream writer
                    try
                    {
                        // Write current location to file
                        this.streamWriter.WriteLine($"{e.Location.X},{e.Location.Y}");

                        // Raise count
                        this.count++;

                        // Update count status label
                        this.countCountToolStripStatusLabel.Text = this.count.ToString();
                    }
                    catch (Exception ex)
                    {
                        // Inform user about exception
                        MessageBox.Show($"{ ex.Message }", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        // Halt flow
                        return;
                    }
                }
            }
        }

        /// <summary>
        /// Handles the global hook mouse move ext.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void GlobalHookMouseMoveExt(object sender, MouseEventExtArgs e)
        {
            // Update status labels
            this.xValueToolStripStatusLabel.Text = e.Location.X.ToString();
            this.yValueToolStripStatusLabel.Text = e.Location.Y.ToString();
        }

        /// <summary>
        /// Subscribe this instance.
        /// </summary>
        private void Subscribe()
        {
            m_GlobalHook = Hook.GlobalEvents();

            m_GlobalHook.MouseDownExt += GlobalHookMouseDownExt;

            m_GlobalHook.MouseMoveExt += GlobalHookMouseMoveExt;
        }

        /// <summary>
        /// Unsubscribe this instance.
        /// </summary>
        private void Unsubscribe()
        {
            m_GlobalHook.MouseDownExt -= GlobalHookMouseDownExt;

            m_GlobalHook.MouseMoveExt -= GlobalHookMouseMoveExt;

            m_GlobalHook.Dispose();
        }

        /// <summary>
        /// Handles the main form load.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnMainFormLoad(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the exit tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Close program
            this.Close();
        }
    }
}
