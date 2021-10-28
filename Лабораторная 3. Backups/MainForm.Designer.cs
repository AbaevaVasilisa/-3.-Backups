
namespace Лабораторная_3.Backups
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddFolder = new System.Windows.Forms.Button();
            this.tbBackupFolderPath = new System.Windows.Forms.TextBox();
            this.gbBackup = new System.Windows.Forms.GroupBox();
            this.gbFiles = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbFilesNames = new System.Windows.Forms.ListBox();
            this.gbBackupMethods = new System.Windows.Forms.GroupBox();
            this.rbSplitStorage = new System.Windows.Forms.RadioButton();
            this.rbSingleStorage = new System.Windows.Forms.RadioButton();
            this.btnMakeBackup = new System.Windows.Forms.Button();
            this.gbBackup.SuspendLayout();
            this.gbFiles.SuspendLayout();
            this.gbBackupMethods.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.Location = new System.Drawing.Point(410, 19);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(160, 23);
            this.btnAddFolder.TabIndex = 0;
            this.btnAddFolder.Text = "Выбрать папку";
            this.btnAddFolder.UseVisualStyleBackColor = true;
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
            // 
            // tbBackupFolderPath
            // 
            this.tbBackupFolderPath.Location = new System.Drawing.Point(6, 19);
            this.tbBackupFolderPath.Name = "tbBackupFolderPath";
            this.tbBackupFolderPath.Size = new System.Drawing.Size(398, 20);
            this.tbBackupFolderPath.TabIndex = 1;
            // 
            // gbBackup
            // 
            this.gbBackup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBackup.Controls.Add(this.tbBackupFolderPath);
            this.gbBackup.Controls.Add(this.btnAddFolder);
            this.gbBackup.Location = new System.Drawing.Point(12, 406);
            this.gbBackup.Name = "gbBackup";
            this.gbBackup.Size = new System.Drawing.Size(576, 52);
            this.gbBackup.TabIndex = 2;
            this.gbBackup.TabStop = false;
            this.gbBackup.Text = "Путь выгрузки бекапа";
            // 
            // gbFiles
            // 
            this.gbFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFiles.Controls.Add(this.btnDelete);
            this.gbFiles.Controls.Add(this.btnAdd);
            this.gbFiles.Controls.Add(this.lbFilesNames);
            this.gbFiles.Location = new System.Drawing.Point(12, 12);
            this.gbFiles.Name = "gbFiles";
            this.gbFiles.Size = new System.Drawing.Size(576, 313);
            this.gbFiles.TabIndex = 3;
            this.gbFiles.TabStop = false;
            this.gbFiles.Text = "Список файлов бекапа";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(6, 279);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(564, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(6, 250);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(564, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbFilesNames
            // 
            this.lbFilesNames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFilesNames.FormattingEnabled = true;
            this.lbFilesNames.Location = new System.Drawing.Point(6, 19);
            this.lbFilesNames.Name = "lbFilesNames";
            this.lbFilesNames.Size = new System.Drawing.Size(564, 225);
            this.lbFilesNames.TabIndex = 4;
            // 
            // gbBackupMethods
            // 
            this.gbBackupMethods.Controls.Add(this.rbSingleStorage);
            this.gbBackupMethods.Controls.Add(this.rbSplitStorage);
            this.gbBackupMethods.Location = new System.Drawing.Point(12, 331);
            this.gbBackupMethods.Name = "gbBackupMethods";
            this.gbBackupMethods.Size = new System.Drawing.Size(576, 69);
            this.gbBackupMethods.TabIndex = 4;
            this.gbBackupMethods.TabStop = false;
            this.gbBackupMethods.Text = "Алгоритмы резервного копирования";
            // 
            // rbSplitStorage
            // 
            this.rbSplitStorage.AutoSize = true;
            this.rbSplitStorage.Checked = true;
            this.rbSplitStorage.Location = new System.Drawing.Point(6, 19);
            this.rbSplitStorage.Name = "rbSplitStorage";
            this.rbSplitStorage.Size = new System.Drawing.Size(267, 17);
            this.rbSplitStorage.TabIndex = 0;
            this.rbSplitStorage.TabStop = true;
            this.rbSplitStorage.Text = "Алгоритм раздельного хранения (Split storages) ";
            this.rbSplitStorage.UseVisualStyleBackColor = true;
            // 
            // rbSingleStorage
            // 
            this.rbSingleStorage.AutoSize = true;
            this.rbSingleStorage.Location = new System.Drawing.Point(6, 42);
            this.rbSingleStorage.Name = "rbSingleStorage";
            this.rbSingleStorage.Size = new System.Drawing.Size(241, 17);
            this.rbSingleStorage.TabIndex = 1;
            this.rbSingleStorage.Text = "Алгоритм общего хранения (Single storage)";
            this.rbSingleStorage.UseVisualStyleBackColor = true;
            // 
            // btnMakeBackup
            // 
            this.btnMakeBackup.Location = new System.Drawing.Point(12, 464);
            this.btnMakeBackup.Name = "btnMakeBackup";
            this.btnMakeBackup.Size = new System.Drawing.Size(576, 49);
            this.btnMakeBackup.TabIndex = 5;
            this.btnMakeBackup.Text = "Создать резервную копию";
            this.btnMakeBackup.UseVisualStyleBackColor = true;
            this.btnMakeBackup.Click += new System.EventHandler(this.btnMakeBackup_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 525);
            this.Controls.Add(this.btnMakeBackup);
            this.Controls.Add(this.gbBackupMethods);
            this.Controls.Add(this.gbFiles);
            this.Controls.Add(this.gbBackup);
            this.Name = "MainForm";
            this.Text = "Лабораторная 3. Backups";
            this.gbBackup.ResumeLayout(false);
            this.gbBackup.PerformLayout();
            this.gbFiles.ResumeLayout(false);
            this.gbBackupMethods.ResumeLayout(false);
            this.gbBackupMethods.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddFolder;
        private System.Windows.Forms.TextBox tbBackupFolderPath;
        private System.Windows.Forms.GroupBox gbBackup;
        private System.Windows.Forms.GroupBox gbFiles;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbFilesNames;
        private System.Windows.Forms.GroupBox gbBackupMethods;
        private System.Windows.Forms.RadioButton rbSingleStorage;
        private System.Windows.Forms.RadioButton rbSplitStorage;
        private System.Windows.Forms.Button btnMakeBackup;
    }
}

