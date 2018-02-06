using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading;


namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        string inputFilePath;
        string outputFilePath;
        string fileName;
        string command = "/C lame ";
        string cmdArgs = "";
        string strCmdText = "";

        Boolean bitrateMode = false;//by default bitrate radiobutton is unchecked
        Boolean qualityMode = true;//default quality radiobutton is checked
        Boolean monoEncoding = false; //by default monoencoding is unchecked
        Boolean CBR_checkbox = false; //by default CBR is unchecked

        private void browseInputBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                inputFilePath = openFileDialog1.FileName;
                fileName = Path.GetFileNameWithoutExtension(inputFilePath);
                textBox1.Text = inputFilePath;
                outputFilePath = Path.GetDirectoryName(inputFilePath) + "\\" + fileName + ".mp3";
                textBox2.Text = outputFilePath;

                outputBtn.Enabled = true;
                textBox2.Enabled = true;
                TargetGroupBox.Enabled = true;
                PriorityGroupBox.Enabled = true;
                MonoCheckBox.Enabled = true;
                QualityBox.Enabled = true;
                EncodeBtn.Enabled = true;
                tb.Enabled = true;

                toolStripStatusLabel1.Text = "Ready...";
                                
            }
        }

        private void outputBtn_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                outputFilePath = folderBrowserDialog1.SelectedPath + "\\" + fileName +".mp3";
                textBox2.Text = outputFilePath;
            }
            
        }
        
        private void EncodeBtn_Click(object sender, EventArgs e)
        {

            if (inputFilePath == null)
            {
                DialogResult res = MessageBox.Show("Please select a source file", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                setCommandArguments();

                Thread LameProcessThread = new Thread(runLameCommand);
                LameProcessThread.Start();
                tsProgressBar.Visible = true;
                tsProgressBar.Style = ProgressBarStyle.Marquee;
                EncodeBtn.Enabled = false;   
                                        
            }
        }
        
         private void runLameCommand()
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            
            startInfo.CreateNoWindow = true;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = strCmdText;
            startInfo.UseShellExecute = false;
            
            process.StartInfo = startInfo;
            process.Start();
            toolStripStatusLabel1.Text = "Encoding...";

            process.WaitForExit();
          
            if (process.HasExited)
            {
                tsProgressBar.Style = ProgressBarStyle.Continuous;
                tsProgressBar.Value = tsProgressBar.Maximum;
                toolStripStatusLabel1.Text = "Done!";
                DialogResult res = MessageBox.Show("File Encoded Succesfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.None);
                tsProgressBar.Visible = false;
                command = "/C lame ";
                cmdArgs = "";
                strCmdText = "";
                toolStripStatusLabel1.Text = "Select Another File...";
                tb.Text = "";
                EncodeBtn.Enabled = true;
                return;
                
            }

        }

        private void setCommandArguments()
        {
            cmdArgs = "";
            String tb_text;

            String bitrateTB = BitrateTrackBar.Value.ToString();// get Bitrate Trackbar Value
            String qualityTB = (QualityTrackBar.Value / 10.0).ToString();//get Quality Trackbar Value
            String priority = PriorityComboBox.SelectedItem.ToString();

            tb_text = bitrateTB + " " + qualityTB;
            tb.Text = tb_text;
            /* Setting Command Parameters 
            target -> bitrate or quality
            if bitrate -> CBR/ABR, by default ABR
            "--abr " + bitrateTB; 
            //if checkbox selected then CBR
            "-b" + bitrateTB;
            */

            /*
            if quality => VBR
            // value from 0 to 9.999
            "-V" + qualityTB;
            */
            if (monoEncoding) {
                cmdArgs = "-m m";
            }
            if (qualityMode)  {
                  cmdArgs += " -V " + qualityTB;
            }
            else if (bitrateMode)
            {
                if (CBR_checkbox)  {
                    cmdArgs += " -b" + bitrateTB;
                }
                else
                {
                    cmdArgs += " --abr " + bitrateTB;
                }
                
            }
            if (priority.Equals("Normal"))
            {
                priority = " --priority 2";
            }
            else if (priority.Equals("Low"))
            {
                priority = " --priority 1";
            }
            else if (priority.Equals("High"))
            {
                priority = " --priority 4";
            }
            cmdArgs += priority;

            strCmdText = command + cmdArgs + " "+ inputFilePath + " " + outputFilePath;
            tb.Text = strCmdText;

        }

        private void BitrateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (BitrateRadioButton.Checked == true)
            {
                BitrateBox.Enabled = true;
                bitrateMode = true;
                qualityMode = false;
                QualityBox.Enabled = false;
            }

        }

        private void QualityRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (QualityRadioButton.Checked == true)
            {
                BitrateBox.Enabled = false;
                bitrateMode = false;
                qualityMode = true;
                QualityBox.Enabled = true;
            }
        }

        private void MonoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MonoCheckBox.Checked == true)
                monoEncoding = true;
            else
                monoEncoding = false;
            
        }

        private void CBRCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(CBRCheckBox.Checked == true)
                CBR_checkbox = true;
            else
                CBR_checkbox = false;
        }

        private void QualityTrackBar_Scroll(object sender, EventArgs e)
        {
            QualityNumericUpDown.Value = QualityTrackBar.Value;

        }

        private void BitrateNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            BitrateTrackBar.Value = (int)BitrateNumericUpDown.Value;

        }

        private void BitrateTrackBar_Scroll(object sender, EventArgs e)
        {
            BitrateNumericUpDown.Value = BitrateTrackBar.Value;
        }

        private void QualityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            QualityTrackBar.Value = (int)(QualityNumericUpDown.Value);
        }

    }
}
