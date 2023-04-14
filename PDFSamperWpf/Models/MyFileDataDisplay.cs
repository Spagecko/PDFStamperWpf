using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 

namespace PDFStamperWpf.Models
{
    public class MyFileDataDisplay
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public long FileSize { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime LastAccessTime { get; set; }
        public DateTime LastWriteTime { get; set; }
        public byte[] FileContent { get; set; }

        public MyFileDataDisplay(string filePath)
        {
            FileInfo fileInfo = new FileInfo(filePath);

            FileName = fileInfo.Name;
            FilePath = fileInfo.FullName;
            FileSize = fileInfo.Length;
            CreationTime = fileInfo.CreationTime;
            LastAccessTime = fileInfo.LastAccessTime;
            LastWriteTime = fileInfo.LastWriteTime;
            FileContent = File.ReadAllBytes(filePath);
        }
    }
}
