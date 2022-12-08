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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;

namespace Result_DB_Speed_Checker
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        // public bool Sorted { get; set; }
        public event System.Windows.Controls.SelectionChangedEventHandler SelectionChanged;
        private void btnOpenFiles_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = "C:\\KYLOG\\AOIGUI\\RESULT";
            if (openFileDialog.ShowDialog().ToString() == "OK")
            {
                foreach (string filename in openFileDialog.FileNames)
                    if(lbFiles.Items.Contains(System.IO.Path.GetFileName(filename)) == false) // 중복된 파일을 작업 리스트에 올리는 것을 방지함
                        lbFiles.Items.Add(System.IO.Path.GetFileName(filename));
                //lbFiles.Sorted = true;
            }
        }

        private void lbFiles_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBoxItem lbi = ((sender as ListBox).SelectedItem as ListBoxItem);
        }
    }
}
