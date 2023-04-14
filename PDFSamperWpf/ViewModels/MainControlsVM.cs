using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Runtime.InteropServices.ComTypes;
using GalaSoft.MvvmLight.Command;
using System.IO;
using System.Windows;
using PDFStamperWpf.Models;
namespace PDFStamperWpf.ViewModels
{
   public class MainControlsVM:ViewModelBase
    {
        public ICommand FileDroppedCommand { get; set; }
        public ObservableCollection<string> Files { get; set; }

        public List<byte[]> fileInMemoray { get; set; }

        private ObservableCollection<MyFileDataDisplay> _fileDataList;
        public ICommand RemoveFileCommand { get; set; }

        public ObservableCollection<MyFileDataDisplay> FileDataList
        {
            get { return _fileDataList; }
            set
            {
                _fileDataList = value;
                RemoveFileCommand = new RelayCommand<MyFileDataDisplay>(RemoveFile);
                OnPropertyChanged(nameof(FileDataList));
            }
        }
        public MainControlsVM()
        {

            //FileDroppedCommand = new RelayCommand<DragEventArgs>(OnFileDropped);
            FileDataList = new ObservableCollection<MyFileDataDisplay>();
            fileInMemoray = new List<byte[]>(); 
            //Files = new ObservableCollection<string>();
        }


        private void RemoveFile(MyFileDataDisplay fileData)
        {
            if (fileData != null && FileDataList.Contains(fileData))
            {
                FileDataList.Remove(fileData);
            }
        }

        //public void OnFileDropped(DragEventArgs e)
        //{
        //    try
        //    {
        //        if (e.Data.GetDataPresent(DataFormats.FileDrop))
        //        {
        //            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
        //            foreach (string file in files)
        //            {
        //                if (File.Exists(file))
        //                {
        //                    Files.Add(file);
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
    }
}
