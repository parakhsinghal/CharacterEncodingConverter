namespace EncodingConversion
{
    partial class frmEncodingConverter
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
            this.lblInformation = new System.Windows.Forms.Label();
            this.lblInputFileLocation = new System.Windows.Forms.Label();
            this.lblInputFileEncoding = new System.Windows.Forms.Label();
            this.lblOutputFileLocation = new System.Windows.Forms.Label();
            this.lblOutputFileEncoding = new System.Windows.Forms.Label();
            this.btnInputFileBrowse = new System.Windows.Forms.Button();
            this.btnOutputFileBrowse = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.comboBoxAvailableEncodings = new System.Windows.Forms.ComboBox();
            this.txtbxInputFileLocation = new System.Windows.Forms.TextBox();
            this.txtbxOutputFileDirectory = new System.Windows.Forms.TextBox();
            this.lblInputFileEncodingInfo = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformation.Location = new System.Drawing.Point(16, 13);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(465, 24);
            this.lblInformation.TabIndex = 0;
            this.lblInformation.Text = "This program is meant to convert encoding of text files.";
            // 
            // lblInputFileLocation
            // 
            this.lblInputFileLocation.AutoSize = true;
            this.lblInputFileLocation.Location = new System.Drawing.Point(16, 59);
            this.lblInputFileLocation.Name = "lblInputFileLocation";
            this.lblInputFileLocation.Size = new System.Drawing.Size(128, 13);
            this.lblInputFileLocation.TabIndex = 1;
            this.lblInputFileLocation.Text = "Choose input file location:";
            // 
            // lblInputFileEncoding
            // 
            this.lblInputFileEncoding.AutoSize = true;
            this.lblInputFileEncoding.Location = new System.Drawing.Point(16, 94);
            this.lblInputFileEncoding.Name = "lblInputFileEncoding";
            this.lblInputFileEncoding.Size = new System.Drawing.Size(109, 13);
            this.lblInputFileEncoding.TabIndex = 2;
            this.lblInputFileEncoding.Text = "Encoding of input file:";
            // 
            // lblOutputFileLocation
            // 
            this.lblOutputFileLocation.AutoSize = true;
            this.lblOutputFileLocation.Location = new System.Drawing.Point(16, 129);
            this.lblOutputFileLocation.Name = "lblOutputFileLocation";
            this.lblOutputFileLocation.Size = new System.Drawing.Size(153, 13);
            this.lblOutputFileLocation.TabIndex = 3;
            this.lblOutputFileLocation.Text = "Choose directory for output file:";
            // 
            // lblOutputFileEncoding
            // 
            this.lblOutputFileEncoding.AutoSize = true;
            this.lblOutputFileEncoding.Location = new System.Drawing.Point(16, 164);
            this.lblOutputFileEncoding.Name = "lblOutputFileEncoding";
            this.lblOutputFileEncoding.Size = new System.Drawing.Size(154, 13);
            this.lblOutputFileEncoding.TabIndex = 4;
            this.lblOutputFileEncoding.Text = "Choose encoding of output file:";
            // 
            // btnInputFileBrowse
            // 
            this.btnInputFileBrowse.Location = new System.Drawing.Point(531, 54);
            this.btnInputFileBrowse.Name = "btnInputFileBrowse";
            this.btnInputFileBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnInputFileBrowse.TabIndex = 5;
            this.btnInputFileBrowse.Text = "Browse";
            this.btnInputFileBrowse.UseVisualStyleBackColor = true;
            this.btnInputFileBrowse.Click += new System.EventHandler(this.btnInputFileBrowse_Click);
            // 
            // btnOutputFileBrowse
            // 
            this.btnOutputFileBrowse.Location = new System.Drawing.Point(531, 124);
            this.btnOutputFileBrowse.Name = "btnOutputFileBrowse";
            this.btnOutputFileBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnOutputFileBrowse.TabIndex = 6;
            this.btnOutputFileBrowse.Text = "Browse";
            this.btnOutputFileBrowse.UseVisualStyleBackColor = true;
            this.btnOutputFileBrowse.Click += new System.EventHandler(this.btnOutputFileBrowse_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(465, 198);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(141, 67);
            this.btnConvert.TabIndex = 7;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // comboBoxAvailableEncodings
            // 
            this.comboBoxAvailableEncodings.FormattingEnabled = true;
            this.comboBoxAvailableEncodings.Location = new System.Drawing.Point(170, 160);
            this.comboBoxAvailableEncodings.Name = "comboBoxAvailableEncodings";
            this.comboBoxAvailableEncodings.Size = new System.Drawing.Size(320, 21);
            this.comboBoxAvailableEncodings.TabIndex = 8;
            // 
            // txtbxInputFileLocation
            // 
            this.txtbxInputFileLocation.Location = new System.Drawing.Point(170, 55);
            this.txtbxInputFileLocation.Name = "txtbxInputFileLocation";
            this.txtbxInputFileLocation.Size = new System.Drawing.Size(320, 20);
            this.txtbxInputFileLocation.TabIndex = 9;
            this.txtbxInputFileLocation.TextChanged += new System.EventHandler(this.txtbxInputFileLocation_TextChanged);
            // 
            // txtbxOutputFileDirectory
            // 
            this.txtbxOutputFileDirectory.Location = new System.Drawing.Point(170, 125);
            this.txtbxOutputFileDirectory.Name = "txtbxOutputFileDirectory";
            this.txtbxOutputFileDirectory.Size = new System.Drawing.Size(320, 20);
            this.txtbxOutputFileDirectory.TabIndex = 10;
            this.txtbxOutputFileDirectory.TextChanged += new System.EventHandler(this.txtbxOutputFileDirectory_TextChanged);
            // 
            // lblInputFileEncodingInfo
            // 
            this.lblInputFileEncodingInfo.AutoSize = true;
            this.lblInputFileEncodingInfo.Location = new System.Drawing.Point(170, 90);
            this.lblInputFileEncodingInfo.Name = "lblInputFileEncodingInfo";
            this.lblInputFileEncodingInfo.Size = new System.Drawing.Size(35, 13);
            this.lblInputFileEncodingInfo.TabIndex = 11;
            this.lblInputFileEncodingInfo.Text = "label1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmEncodingConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 275);
            this.Controls.Add(this.lblInputFileEncodingInfo);
            this.Controls.Add(this.txtbxOutputFileDirectory);
            this.Controls.Add(this.txtbxInputFileLocation);
            this.Controls.Add(this.comboBoxAvailableEncodings);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnOutputFileBrowse);
            this.Controls.Add(this.btnInputFileBrowse);
            this.Controls.Add(this.lblOutputFileEncoding);
            this.Controls.Add(this.lblOutputFileLocation);
            this.Controls.Add(this.lblInputFileEncoding);
            this.Controls.Add(this.lblInputFileLocation);
            this.Controls.Add(this.lblInformation);
            this.Name = "frmEncodingConverter";
            this.Text = "Encoding Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Label lblInputFileLocation;
        private System.Windows.Forms.Label lblInputFileEncoding;
        private System.Windows.Forms.Label lblOutputFileLocation;
        private System.Windows.Forms.Label lblOutputFileEncoding;
        private System.Windows.Forms.Button btnInputFileBrowse;
        private System.Windows.Forms.Button btnOutputFileBrowse;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.ComboBox comboBoxAvailableEncodings;
        private System.Windows.Forms.TextBox txtbxInputFileLocation;
        private System.Windows.Forms.TextBox txtbxOutputFileDirectory;
        private System.Windows.Forms.Label lblInputFileEncodingInfo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

