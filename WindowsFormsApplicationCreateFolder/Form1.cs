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
using RSRC;


namespace WindowsFormsApplicationCreateFolder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// button Browse handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            txtLocation.Text = GetPath();
        }

        private void btnCreateFolder_Click(object sender, EventArgs e)
        {
            var folderPath = GetFolderPath(txtLocation.Text);
            var dir = folderPath + txtFolderName.Text;
            Directory.CreateDirectory(dir);
            MessageBox.Show(Farsi.SuccessCreated + dir);
        }
        /// <summary>
        /// OpenFileDialog class
        /// </summary>
        /// <returns>
        /// returns the selected file path in string format
        /// </returns>
        public string GetPath()
        {
            var path = string.Empty;
            var fdlg = new OpenFileDialog();
            fdlg.Title = RSRC.Farsi.SelectFile;
            fdlg.InitialDirectory = RSRC.Setting.InitialPath;

            fdlg.FilterIndex = 1;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
                path = fdlg.FileName;
            return path;
        }

        private void btnBrowseRnm_Click(object sender, EventArgs e)
        {
            var filePath = GetPath();
            string folderPath = GetFolderPath(filePath);
            txtfldr2Rnm.Text = folderPath;
        }

        private string GetFolderPath(string filePath)
        {
            var strArr = filePath.Split('\\');
            var sb = new StringBuilder();
            for (int i = 0; i < strArr.Length - 1; i++)
            {
                sb.Append(strArr[i]);
                sb.Append("\\");
            }
            return sb.ToString();
        }

        private void btnRenameFiles_Click(object sender, EventArgs e)
        {
            var folderPath = txtfldr2Rnm.Text;
            var Prefix = txtNewNamePrefix.Text;
            var dir = new DirectoryInfo(folderPath);
            var imageFiles =
                dir.GetFiles("*.jpg", SearchOption.AllDirectories);
            var pdfFiles =
                dir.GetFiles("*.pdf", SearchOption.AllDirectories);
            var resArr = new FileInfo[imageFiles.Length + pdfFiles.Length];
            imageFiles.CopyTo(resArr, 0);
            pdfFiles.CopyTo(resArr,imageFiles.Length);
            foreach (var item in resArr)
            {
                var oldAddress = folderPath + item.Name;
                var newAddress = folderPath + Prefix + item.Name;
                if (oldAddress.Contains(Prefix))
                    continue;
                File.Move(oldAddress, newAddress);
            }
            MessageBox.Show(RSRC.Farsi.success);
        }

        private void btnDisplayImg_Click(object sender, EventArgs e)
        {
            var folderPath = GetFolderPath(txtLocation.Text);
            DisplayImageFiles(folderPath);
        }

        private void DisplayImageFiles(string folderPath)
        {
            listBox1.Items.Clear();
            var dir = new DirectoryInfo(folderPath);
            var imageFiles = dir.GetFiles("*.jpg", SearchOption.AllDirectories);
            foreach (FileInfo f in imageFiles)
            {
                listBox1.Items.Add(f.Name);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("place: " +
                System.Reflection.MethodInfo.GetCurrentMethod().Name);
        }
    }
}