namespace LoadFileSplitSQL
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Button_Open = new System.Windows.Forms.Button();
            this.ButtonSplit = new System.Windows.Forms.Button();
            this.ButtonDestination = new System.Windows.Forms.Button();
            this.TextBoxDestinationPath = new System.Windows.Forms.TextBox();
            this.TextBoxSource = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Button_Open
            // 
            this.Button_Open.Location = new System.Drawing.Point(40, 55);
            this.Button_Open.Name = "Button_Open";
            this.Button_Open.Size = new System.Drawing.Size(513, 23);
            this.Button_Open.TabIndex = 0;
            this.Button_Open.Text = "Open File";
            this.Button_Open.UseVisualStyleBackColor = true;
            this.Button_Open.Click += new System.EventHandler(this.Button_Open_Click);
            // 
            // ButtonSplit
            // 
            this.ButtonSplit.Location = new System.Drawing.Point(245, 234);
            this.ButtonSplit.Name = "ButtonSplit";
            this.ButtonSplit.Size = new System.Drawing.Size(97, 50);
            this.ButtonSplit.TabIndex = 1;
            this.ButtonSplit.Text = "Split SQL File";
            this.ButtonSplit.UseVisualStyleBackColor = true;
            this.ButtonSplit.Click += new System.EventHandler(this.ButtonSplit_Click);
            // 
            // ButtonDestination
            // 
            this.ButtonDestination.Location = new System.Drawing.Point(40, 164);
            this.ButtonDestination.Name = "ButtonDestination";
            this.ButtonDestination.Size = new System.Drawing.Size(513, 23);
            this.ButtonDestination.TabIndex = 2;
            this.ButtonDestination.Text = "Destination Folder";
            this.ButtonDestination.UseVisualStyleBackColor = true;
            this.ButtonDestination.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextBoxDestinationPath
            // 
            this.TextBoxDestinationPath.Location = new System.Drawing.Point(40, 138);
            this.TextBoxDestinationPath.Name = "TextBoxDestinationPath";
            this.TextBoxDestinationPath.Size = new System.Drawing.Size(513, 20);
            this.TextBoxDestinationPath.TabIndex = 3;
            // 
            // TextBoxSource
            // 
            this.TextBoxSource.Location = new System.Drawing.Point(40, 29);
            this.TextBoxSource.Name = "TextBoxSource";
            this.TextBoxSource.Size = new System.Drawing.Size(513, 20);
            this.TextBoxSource.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Source SQL File to split";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Folder to save split SQL files";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 299);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxSource);
            this.Controls.Add(this.TextBoxDestinationPath);
            this.Controls.Add(this.ButtonDestination);
            this.Controls.Add(this.ButtonSplit);
            this.Controls.Add(this.Button_Open);
            this.Name = "Form1";
            this.Text = "SQL File Spliter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Button_Open;
        private System.Windows.Forms.Button ButtonSplit;
        private System.Windows.Forms.Button ButtonDestination;
        private System.Windows.Forms.TextBox TextBoxDestinationPath;
        private System.Windows.Forms.TextBox TextBoxSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

