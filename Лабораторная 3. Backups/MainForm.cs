using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.ListBox;

namespace Лабораторная_3.Backups
{
    public partial class MainForm : Form
    {
        #region Поля
        private List<FileLite> filesList;
        #endregion

        #region Конструктор
        public MainForm()
        {
            this.InitializeComponent();
            this.filesList = new List<FileLite>();
        }
        #endregion

        #region Методы
        private void AddBackupFolder()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Выберите папку";
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                this.tbBackupFolderPath.Text = folderBrowserDialog.SelectedPath;
        }
        private void AddBackupFiles()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Все файлы (*.*)|*.*";
            openFileDialog.Multiselect = true;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < openFileDialog.FileNames.Length; i++)
                    this.filesList.Add(new FileLite(openFileDialog.FileNames[i]));
            }
        }
        private void DeleteBackupFile(int index)
        {
            if (index >= 0 && index < this.lbFilesNames.Items.Count)
                this.filesList.RemoveAt(index);
        }
        private void DeleteBackupFiles(SelectedIndexCollection indices)
        {
            throw new NotImplementedException();
        }
        private void UpdateFIlesList()
        {
            if (this.filesList != null)
            {
                this.lbFilesNames.Items.Clear();
                foreach (var item in this.filesList)
                    this.lbFilesNames.Items.Add(item.fullName);
            }
        }

        #endregion

        #region События формы
        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            this.AddBackupFolder();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.AddBackupFiles();
            this.UpdateFIlesList();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.DeleteBackupFile(this.lbFilesNames.SelectedIndex);
            this.UpdateFIlesList();
        }
        private void btnMakeBackup_Click(object sender, EventArgs e)
        {
            MyJob backupJob = new MyJob();
            if (this.rbSingleStorage.Checked)
                backupJob.MakeBackup(this.tbBackupFolderPath.Text, this.filesList, BackupType.single);
            if (this.rbSplitStorage.Checked)
                backupJob.MakeBackup(this.tbBackupFolderPath.Text, this.filesList, BackupType.split);
            MessageBox.Show("Резервная точка создана!", "Операция завершена", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

    }
}
