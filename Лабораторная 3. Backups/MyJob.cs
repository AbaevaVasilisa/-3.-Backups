using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;

namespace Лабораторная_3.Backups
{
    public enum BackupType
    {
        single,
        split
    }
    public class MyJob
    {

        private void MakeSplitBackup(String path, List<FileLite> filesList)
        {
            foreach (var file in filesList)
            {
                if (file.extension != ".zip")
                {
                    String zipPath = String.Format("{0}\\{1}.zip", path, file.shortName);
                    if (File.Exists(zipPath))
                        File.Delete(zipPath);
                    using (var archive = ZipFile.Open(zipPath, ZipArchiveMode.Create))
                    {
                        archive.CreateEntryFromFile(file.fullName, file.shortName);
                    }
                }
                else
                {
                    String copyPath = String.Format("{0}\\{1}", path, file.shortName);
                    if (!File.Exists(copyPath))
                        File.Copy(file.fullName, copyPath);
                }
            }
        }
        private void MakeSingleBackup(String path, List<FileLite> filesList)
        {
            String dateStr = String.Format("{0} {1}_{2}_{3}", DateTime.Now.ToShortDateString(), DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            String zipPath = String.Format("{0}\\{1}.zip", path, dateStr);
            if (File.Exists(zipPath))
                File.Delete(zipPath);
            using (var archive = ZipFile.Open(zipPath, ZipArchiveMode.Create))
            {
                foreach (var file in filesList)
                    archive.CreateEntryFromFile(file.fullName, file.shortName);
            }

        }
        public void MakeBackup(String path, List<FileLite> filesList, BackupType backupType)
        {
            if (filesList != null && filesList.Count > 0)
            {
                if (backupType == BackupType.single)
                    this.MakeSingleBackup(path, filesList);
                if (backupType == BackupType.split)
                    this.MakeSplitBackup(path, filesList);
            }
        }
    }
}
