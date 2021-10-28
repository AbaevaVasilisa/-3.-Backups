using System.IO;

namespace Лабораторная_3.Backups
{
    public class FileLite
    {
        /// <summary>
        /// Короткое имя файла с расширением
        /// </summary>
        public string shortName { set; get; }
        /// <summary>
        /// Полное имя файла
        /// </summary>
        public string fullName { set; get; }
        /// <summary>
        /// Расширение
        /// </summary>
        public string extension { set; get; }
        public FileLite(string shortName, string fullName)
        {
            this.shortName = shortName;
            this.fullName = fullName;
        }
        public FileLite(string fullName)
        {
            this.fullName = fullName;
            this.shortName = Path.GetFileName(fullName);
            this.extension = Path.GetExtension(fullName);
        }
    }
}
