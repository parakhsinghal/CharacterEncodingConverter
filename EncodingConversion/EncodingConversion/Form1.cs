using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace EncodingConversion
{
    public partial class frmEncodingConverter : Form
    {
        FileInfo inputFile;
        DirectoryInfo outputDirectory;
        string outputFileName = string.Empty;
        string lineOfData = string.Empty;
        Encoding selectedEncoding;
        int codePage = 0;

        public frmEncodingConverter()
        {
            InitializeComponent();

            // Initializing the labels to empty strings.
            lblInputFileEncodingInfo.Text = string.Empty;

            // Reading all the available encodings.
            Dictionary<int, string> encodings = new Dictionary<int, string>();

            foreach (EncodingInfo encodingInfo in Encoding.GetEncodings())
            {
                encodings.Add(encodingInfo.CodePage, encodingInfo.DisplayName);
            }

            comboBoxAvailableEncodings.DataSource = new BindingSource(encodings, null);
            comboBoxAvailableEncodings.DisplayMember = "Value";
            comboBoxAvailableEncodings.ValueMember = "Key";
        }

        private void btnInputFileBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                inputFile = new FileInfo(openFileDialog1.FileName);
                txtbxInputFileLocation.Text = inputFile.FullName;
                lblInputFileEncodingInfo.Text = string.Empty;
                lblInputFileEncodingInfo.Text = GetInputFileEncoding(inputFile.FullName);
            }
        }

        private void btnOutputFileBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                outputDirectory = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
                txtbxOutputFileDirectory.Text = outputDirectory.FullName;
            }

        }

        private void txtbxOutputFileDirectory_TextChanged(object sender, EventArgs e)
        {
            string outputDirectoryLocation = txtbxOutputFileDirectory.Text;

            if (outputDirectoryLocation.Length > 0 && Directory.Exists(outputDirectoryLocation))
            {
                outputDirectory = new DirectoryInfo(outputDirectoryLocation);
            }
            else
            {
                MessageBox.Show("Output directory does not exists. Please select a valid directory.", "Output directory error", MessageBoxButtons.OK);
            }
        }

        private void txtbxInputFileLocation_TextChanged(object sender, EventArgs e)
        {
            string inputFileLocation = txtbxInputFileLocation.Text;

            if (inputFileLocation.Length > 0 && File.Exists(inputFileLocation))
            {
                inputFile = new FileInfo(inputFileLocation);
                lblInputFileEncodingInfo.Text = string.Empty;
                lblInputFileEncodingInfo.Text = GetInputFileEncoding(inputFile.FullName);
            }
            else
            {
                MessageBox.Show("Input file does not exists. Please select a valid file.", "Input file error", MessageBoxButtons.OK);
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            // Pseudo-code:
            // Check the existence of input file
            // Check the existence of output directory
            // Take into account the user selection of the encoding

            if (InputParametersExists())
            {
                DisableControls();
                codePage = int.Parse(comboBoxAvailableEncodings.SelectedValue.ToString());
                selectedEncoding = Encoding.GetEncoding(codePage);

                outputFileName = outputDirectory.FullName + @"\" + inputFile.Name;

                using (StreamReader reader = new StreamReader(inputFile.FullName, true))
                {
                    using (StreamWriter writer = new StreamWriter(outputFileName, true, selectedEncoding))
                    {
                        while ((lineOfData = reader.ReadLine()) != null)
                        {
                            writer.WriteLine(lineOfData);
                        }
                    }
                }

                MessageBox.Show("Encoding conversion complete.", "Encoding conversion complete.", MessageBoxButtons.OK);
                EnableControls();
            }
            else
            {
                MessageBox.Show("At least one of the input parameters is not valid. Please check for the existence of the input file, output directory and selection of a valid encoding.", "Error in processing", MessageBoxButtons.OK);
            }

        }

        private bool InputParametersExists()
        {
            if (InputFileExists() && OutputDirectoryExists() && EncodingHasBeenSelected())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool InputFileExists()
        {
            if (inputFile != null && inputFile.Exists)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool OutputDirectoryExists()
        {
            if (outputDirectory != null && outputDirectory.Exists)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool EncodingHasBeenSelected()
        {
            if (int.Parse(comboBoxAvailableEncodings.SelectedValue.ToString()) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string GetInputFileEncoding(string fileLocation)
        {
            using (StreamReader reader = new StreamReader(fileLocation))
            {
                return reader.CurrentEncoding.EncodingName;
            }
        }

        private void EnableControls()
        {
            txtbxInputFileLocation.Enabled = true;
            txtbxOutputFileDirectory.Enabled = true;
            btnInputFileBrowse.Enabled = true;
            btnOutputFileBrowse.Enabled = true;
            btnConvert.Enabled = true;
            comboBoxAvailableEncodings.Enabled = true;
        }

        private void DisableControls()
        {
            txtbxInputFileLocation.Enabled = false;
            txtbxOutputFileDirectory.Enabled = false;
            btnInputFileBrowse.Enabled = false;
            btnOutputFileBrowse.Enabled = false;
            btnConvert.Enabled = false;
            comboBoxAvailableEncodings.Enabled = false;
        }
    }
}
