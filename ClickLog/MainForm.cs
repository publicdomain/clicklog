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
    using System.Reflection;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;
    using Gma.System.MouseKeyHook;
    using PublicDomain;

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
        /// Gets or sets the associated icon.
        /// </summary>
        /// <value>The associated icon.</value>
        private Icon associatedIcon = null;

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

            /* Set icons */

            // Set associated icon from exe file
            this.associatedIcon = Icon.ExtractAssociatedIcon(typeof(MainForm).GetTypeInfo().Assembly.Location);

            // Set PublicDomain.is tool strip menu item image
            this.freeReleasesPublicDomainisToolStripMenuItem.Image = this.associatedIcon.ToBitmap();
        }

        /// <summary>
        /// Handles the new tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnNewToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Clear text box
            this.logFileTextBox.Clear();

            // Check for Sto(p)
            if (this.startStopButton.Text.EndsWith("p", StringComparison.InvariantCulture))
            {
                // Click button
                this.startStopButton.PerformClick();
            }

            // Reset count
            this.countCountToolStripStatusLabel.Text = "0";

            // Focus text box
            this.logFileTextBox.Focus();
        }

        /// <summary>
        /// Handles the options tool strip menu item drop down item clicked.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOptionsToolStripMenuItemDropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Set clicked item
            var clickedItem = (ToolStripMenuItem)e.ClickedItem;

            // Toggle checked
            clickedItem.Checked = !clickedItem.Checked;

            // Set topmost
            this.TopMost = clickedItem.Checked;
        }

        /// <summary>
        /// Handles the free releases PublicDomain.is tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnFreeReleasesPublicDomainisToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open our website
            Process.Start("https://publicdomain.is");
        }

        /// <summary>
        /// Handles the original thread redditcom tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOriginalThreadRedditcomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open orignal thread
            Process.Start("https://www.reddit.com/r/software/comments/uh0moz/a_program_to_get_multiple_clicked_coordinates_in/");
        }

        /// <summary>
        /// Handles the source code githubcom tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSourceCodeGithubcomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open GitHub repository
            Process.Start("https://github.com/publicdomain/clicklog");
        }

        /// <summary>
        /// Handles the about tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnAboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Set license text
            var licenseText = $"CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication{Environment.NewLine}" +
                $"https://creativecommons.org/publicdomain/zero/1.0/legalcode{Environment.NewLine}{Environment.NewLine}" +
                $"Libraries and icons have separate licenses.{Environment.NewLine}{Environment.NewLine}" +
                $"MouseKeyHook library by gmamaladze - MIT License{Environment.NewLine}" +
                $"https://github.com/gmamaladze/globalmousekeyhook{Environment.NewLine}{Environment.NewLine}" +
                $"Flat icon by janjf93 - Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/vectors/flat-design-symbol-icon-www-2126879/{Environment.NewLine}{Environment.NewLine}" +
                $"Reddit icon used according to published brand guidelines{Environment.NewLine}" +
                $"https://www.redditinc.com/brand{Environment.NewLine}{Environment.NewLine}" +
                $"GitHub mark icon used according to published logos and usage guidelines{Environment.NewLine}" +
                $"https://github.com/logos{Environment.NewLine}{Environment.NewLine}" +
                $"PublicDomain icon is based on the following source images:{Environment.NewLine}{Environment.NewLine}" +
                $"Bitcoin by GDJ - Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/vectors/bitcoin-digital-currency-4130319/{Environment.NewLine}{Environment.NewLine}" +
                $"Letter P by ArtsyBee - Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/illustrations/p-glamour-gold-lights-2790632/{Environment.NewLine}{Environment.NewLine}" +
                $"Letter D by ArtsyBee - Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/illustrations/d-glamour-gold-lights-2790573/{Environment.NewLine}{Environment.NewLine}";

            // Prepend sponsors
            licenseText = $"RELEASE SPONSORS:{Environment.NewLine}{Environment.NewLine}* Jesse Reichler{Environment.NewLine}* Max P.{Environment.NewLine}* Kathryn S.{Environment.NewLine}* Y0himba{Environment.NewLine}{Environment.NewLine}=========={Environment.NewLine}{Environment.NewLine}" + licenseText;

            // Set title
            string programTitle = typeof(MainForm).GetTypeInfo().Assembly.GetCustomAttribute<AssemblyTitleAttribute>().Title;

            // Set version for generating semantic version
            Version version = typeof(MainForm).GetTypeInfo().Assembly.GetName().Version;

            // Set about form
            var aboutForm = new AboutForm(
                $"About {programTitle}",
                $"{programTitle} {version.Major}.{version.Minor}.{version.Build}",
                $"Made for: u/Xeu1009X10{ Environment.NewLine}Reddit.com{Environment.NewLine}Day #126, Week #18 @ May 06, 2022",
                licenseText,
                this.Icon.ToBitmap())
            {
                // Set about form icon
                Icon = this.associatedIcon,

                // Set always on top
                TopMost = this.TopMost
            };

            // Show about form
            aboutForm.ShowDialog();
        }

        /// <summary>
        /// Handles the start stop button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnStartStopButtonClick(object sender, EventArgs e)
        {
            // Check for Star(t) vs Sto(p)
            if (this.startStopButton.Text.EndsWith("t", StringComparison.InvariantCulture))
            {
                // Open stream writer
                try
                {
                    // Open file for append or overwrite
                    this.streamWriter = new StreamWriter(this.logFileTextBox.Text, this.appendRadioButton.Checked)
                    {
                        // TODO Autoflush [Can be made optional]
                        AutoFlush = true
                    };
                }
                catch (Exception ex)
                {
                    // Inform user about exception
                    MessageBox.Show($"{ ex.Message }", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Halt flow
                    return;
                }

                // Change to stop
                this.startStopButton.Text = "&Stop";
                this.startStopButton.ForeColor = Color.Red;

                // Start
                this.Subscribe();
            }
            else
            {
                // Close stream writer
                try
                {
                    // Close file
                    if (streamWriter != null)
                    {
                        this.streamWriter.Close();
                    }
                }
                catch (Exception ex)
                {
                    // Inform user about exception
                    MessageBox.Show($"{ ex.Message }", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Halt flow
                    return;
                }

                // Reset to start
                this.startStopButton.Text = "&Start";
                this.startStopButton.ForeColor = Color.DarkGreen;

                // Reset status labels
                this.xValueToolStripStatusLabel.Text = "0";
                this.yValueToolStripStatusLabel.Text = "0";

                // Stop
                this.Unsubscribe();
            }
        }

        /// <summary>
        /// Handles the browse button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnBrowseButtonClick(object sender, EventArgs e)
        {
            // Open save file dialog
            if (this.logSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Set into text box
                this.logFileTextBox.Text = this.logSaveFileDialog.FileName;
            }
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
