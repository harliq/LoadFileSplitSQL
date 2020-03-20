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

namespace LoadFileSplitSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open SQL File";
            ofd.Filter = "SQL files|*.sql";
            ofd.InitialDirectory = @"C:\";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                TextBoxSource.Text = ofd.FileName.ToString();
                // MessageBox.Show(ofd.FileName.ToString());
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

                FolderBrowserDialog sourceFolderBrowserDialog = new FolderBrowserDialog();
                sourceFolderBrowserDialog.ShowNewFolderButton = true;

                DialogResult result = sourceFolderBrowserDialog.ShowDialog();
                if (result == DialogResult.OK)
                {

                    TextBoxDestinationPath.Text = sourceFolderBrowserDialog.SelectedPath;

                }

        }

        private void ButtonSplit_Click(object sender, EventArgs e)
        {

            int counter = 0;
            int filecounter = 0;
            string line;
            string newFileText = "";
            string filename = "DnF_SQL";

            // Read the file and display it line by line.  
            System.IO.StreamReader file = new System.IO.StreamReader(TextBoxSource.Text);
            while ((line = file.ReadLine()) != null)
            {
                string tline = line.Trim();
                if (tline.Contains("DELETE FROM" ))
                {

                    string[] getFileName = tline.Split(new[] {" "}, StringSplitOptions.None);
                    // open new file, and get stuff
                    filename = getFileName[2].Replace("`", "");

                    if (File.Exists(TextBoxDestinationPath.Text + @"\" + filename + ".sql"))
                    {
                        filename += "_" + filecounter.ToString();
                    }
                        // write file
                    using (var streamwriter = new System.IO.StreamWriter(TextBoxDestinationPath.Text + @"\" + filename + ".sql", true))
                    {
                        streamwriter.Write(newFileText);
                    }

                    newFileText = line + Environment.NewLine;
                    filecounter++;
                }
                else
                {
                    newFileText += tline + Environment.NewLine;
                }
                // System.Console.WriteLine(line);
                // filecounter++;
                counter++;
            }

            file.Close();
            MessageBox.Show("Split is complete");
        }
    }
}
