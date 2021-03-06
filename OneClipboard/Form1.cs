using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using WK.Libraries.SharpClipboardNS;

namespace OneClipboard
{
    public partial class Form1 : Form
    {
        RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);


        public Form1()
        {
            InitializeComponent();

            // sets opacity to 100 if the app is not found in the startup registry
            // or set to 0 if it is
            if (rkApp.GetValue("OneClipboard") == null)
            {
                this.Opacity = 100;
            }
            else
            {
                checkBoxStartup.Checked = true;
                this.Opacity = 0;
            }
            string clipboard_path;
            try { clipboard_path = Properties.Settings.Default["clipboard_file_path"].ToString(); }
            catch { clipboard_path = ""; }
            if (string.IsNullOrEmpty(clipboard_path))
            {
                labelFileSelected.Text = "No File Selected.";
            }
            else
            {
                labelFileSelected.Text = Properties.Settings.Default["clipboard_file_path"].ToString();
                fileSystemWatcher.Path = Path.GetDirectoryName(Properties.Settings.Default["clipboard_file_path"].ToString());
                labelStartWatch.Text = "Watching folder...";
            }
            getClipboardData();
        }
        // opens file dialog to allow file selection for the text file
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                //following lines save the selected file's path to app settings to be used when the app launches again
                // or when launching during startup
                Properties.Settings.Default["clipboard_file_path"] = openFileDialog.FileName;
                Properties.Settings.Default.Save();
                labelFileSelected.Text = Properties.Settings.Default["clipboard_file_path"].ToString();
            }
        }

        // changes the window's opacity as the icon in the system tray is clicked
        // change if a better way of making the window visible is known
        private void notifyIcon_Click(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity = 0;
            }
            else
            {
                this.Opacity = 100;
                this.Activate();
            }
        }

        // Sets the app to launch on startup if checkBox is set to Checked
        private void checkBoxStartup_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxStartup.Checked)
            {
                rkApp.SetValue("OneClipboard", Application.ExecutablePath);
            }
            else
            {
                rkApp.DeleteValue("OneClipboard", false);
            }
        }

        // adds text in the RichTextBox to the clipboard
        private void buttonAddtoClip_Click(object sender, EventArgs e)
        {
            
            //writeClipboardFile(richTextBoxClipboard.Text);
            Clipboard.SetText(richTextBoxClipboard.Text);
        }

        // Start listening to the file changes for updates
        private void buttonStartWatch_Click(object sender, EventArgs e)
        {
            string clipboard_path;
            try { clipboard_path = Properties.Settings.Default["clipboard_file_path"].ToString(); }
            catch { clipboard_path = ""; }
            if (!string.IsNullOrEmpty(clipboard_path))
            {

                fileSystemWatcher.Path = Path.GetDirectoryName(Properties.Settings.Default["clipboard_file_path"].ToString());
                labelStartWatch.Text = "Watching folder...";
            }
            else { MessageBox.Show("No file could be found, select a file."); }
        }

        // listens to the file changes for updates
        private void fileSystemWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            readClipboardFile();
        }


        private void getClipboardData()
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
            {
                string clipData = (String)Clipboard.GetDataObject().GetData(DataFormats.Text);

                richTextBoxClipboard.Text = clipData;
            }
        }

        private void readClipboardFile()
        {
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(Properties.Settings.Default["clipboard_file_path"].ToString()))
                {
                    
                    string line = sr.ReadToEnd();
                    //Check if the read string is the same as clipboard text
                    if (line != (string)Clipboard.GetDataObject().GetData(DataFormats.Text))
                    {
                        Clipboard.SetText(line);
                        getClipboardData();
                    }


                }
            }
            catch (Exception exception)
            {
                // Let the user know what went wrong.
                MessageBox.Show("The file could not be read:\n Error Message: " + exception.Message);

            }
        }

        //writes data to he clipboard file in OneDrive
        private void writeClipboardFile(string data)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(Properties.Settings.Default["clipboard_file_path"].ToString()))
                {
                    sw.Write(data);
                }
            }
            catch (Exception exception)
            {
                //MessageBox.Show("The file could not be written:\n Error Message: " + exception.Message);
            }
            

        }
        // listens for clipboard changes and writes the text to the clipboard file
        private void sharpClipboard_ClipboardChanged(object sender, SharpClipboard.ClipboardChangedEventArgs e)
        {

            writeClipboardFile((String)Clipboard.GetDataObject().GetData(DataFormats.Text));
            getClipboardData();
            
        }

        /* REMARKS
         * The listeners confuse me, sometimes they report 1 change twice
         * i ignore their exceptions on purpose
         */
    }
}
