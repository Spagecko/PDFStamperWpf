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

namespace PDFStamperWpf.ViewModels
{
   public class MainControlsVM:ViewModelBase
    {
        public ICommand FileDroppedCommand { get; set; }
        public ObservableCollection<string> Files { get; set; }

        public MainControlsVM()
        {
            
            //FileDroppedCommand = new RelayCommand<DragEventArgs>(OnFileDropped);
            Files = new ObservableCollection<string>();
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
