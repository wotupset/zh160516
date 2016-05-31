using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace WA1050531
{
    class MyFileInfo
    {
        private string path;

        private int folderCount;
        private int fileCount;
        private long totalSize;

        public int FolderCount { get { return this.folderCount; } }
        public int FileCount { get { return this.fileCount; } }
        public long TotalSize { get { return this.totalSize; } }

        public MyFileInfo(string path)
        {
            this.path = path;
            CountFileInfo(this.path);
        }

        private void CountFileInfo(string path)
        {
            DirectoryInfo dii = new DirectoryInfo(path);

            foreach (DirectoryInfo di in dii.GetDirectories())
            {
                folderCount++;
                CountFileInfo(di.FullName);
            }
            foreach (FileInfo fi in dii.GetFiles())
            {
                fileCount++;
                totalSize += fi.Length;                
            }        
        }

    }
}
