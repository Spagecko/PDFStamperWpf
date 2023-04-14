using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.IO;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PDFStamperWpf.Models;

namespace PDFStamperWpf.Views
{
    /// <summary>
    /// Interaction logic for MainControlsLayout.xaml
    /// </summary>
    public partial class MainControlsLayout : UserControl
    {
        public ViewModels.MainControlsVM  mainControlsVM { get; set; }
        public MainControlsLayout()
        {
            InitializeComponent();
            mainControlsVM = new ViewModels.MainControlsVM();
            DataContext = mainControlsVM;
        }

        private void fileDropStackPanel_Drop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            string fileName = System.IO.Path.GetFileName(files[0]);
            byte[] ReadFileContent = File.ReadAllBytes(files[0]);
            MyFileDataDisplay myFileDataDisplay = new MyFileDataDisplay(System.IO.Path.GetFullPath(files[0]));
            //mainControlsVM.fileInMemoray.Add(ReadFileContent);'
            mainControlsVM.FileDataList.Add(myFileDataDisplay);


                //mainControlsVM.Files.Add(System.IO.Path.GetFullPath(files[0]));


            //fileNameLabel.Content = fileName;
        }
    }
}
