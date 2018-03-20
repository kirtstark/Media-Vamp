using fileSelector2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace EntertainMe
{
    public partial class Form1 : Form
    {
        private string license = @"Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the 'Software'), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED 'AS IS', WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.";
        
        public Form1()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.uiMode = "full";
            axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(player_PlayStateChange);

        }

        private void player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 3 && checkBoxFullScreen.Checked)
            {
                axWindowsMediaPlayer1.fullScreen = true;
            }
            else
                axWindowsMediaPlayer1.fullScreen = false;
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            string currentMethod = @"buttonBrowse_Click(object sender, EventArgs e)";
            
            try
            {
                DialogResult result = folderBrowserDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    labelFileName.Text = folderBrowserDialog1.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in " + currentMethod + ": " + ex.Message, "Error");
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            List<string> mediaFiles = new List<string>();
            string fileTye = string.Empty;
            IWMPPlaylistCollection pListColl;
            IWMPPlaylist pList;
            WMPLib.IWMPMedia media;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                if (!checkBoxAudioFiles.Checked && !checkBoxVideoFiles.Checked)
                {
                    MessageBox.Show("You must select either audio or video files or both", "Alert");
                    return;
                }
                else if (checkBoxAudioFiles.Checked && checkBoxVideoFiles.Checked)
                {
                    fileTye = "all";
                }
                else if (checkBoxAudioFiles.Checked)
                {
                    fileTye = "audio";
                }
                else
                {
                    fileTye = "video";
                }

                if (!Directory.Exists(labelFileName.Text))
                {
                    MessageBox.Show("You must select a valid directory", "Alert");
                    return;
                }

                if (checkBoxFileLength.Checked)
                {
                    int minSec = Decimal.ToInt32(numericUpDownMinTimeSec.Value + (numericUpDownMinTimeMin.Value * 60));
                    int maxSec = Decimal.ToInt32(numericUpDownMaxTimeSec.Value + (numericUpDownMaxTimeMin.Value * 60));

                    if (minSec < 0.0 || maxSec < 0.0 || maxSec <= minSec || Decimal.ToInt32(numericUpDownMinTimeSec.Value) < 0 ||
                        Decimal.ToInt32(numericUpDownMinTimeMin.Value) < 0 || Decimal.ToInt32(numericUpDownMaxTimeSec.Value) < 0 ||
                        Decimal.ToInt32(numericUpDownMaxTimeSec.Value) < 0)
                    {
                        MessageBox.Show("You must enter valid time values", "Alert");
                        return;
                    }

                    mediaFiles = cChooseFile.getFilesFromDirectory(labelFileName.Text, fileTye, minSec, maxSec, true, (int)numericUpDown1.Value);
                }
                else
                {
                    mediaFiles = cChooseFile.getFilesFromDirectory(labelFileName.Text, fileTye, false, (int)numericUpDown1.Value);
                }

                pListColl = axWindowsMediaPlayer1.playlistCollection;
                pList = pListColl.newPlaylist("myPlaylist__158463578147afgrhertefdb");

                foreach (string file in mediaFiles)
                {
                    media = axWindowsMediaPlayer1.newMedia(file);
                    pList.appendItem(media);
                }

                if (mediaFiles.Count > 0)
                {
                    axWindowsMediaPlayer1.currentPlaylist = pList;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
                else
                    Console.WriteLine("no files");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error!");
                return;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void buttonLicensing_Click(object sender, EventArgs e)
        {
            MessageBox.Show(license, "Licensing:", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    
}