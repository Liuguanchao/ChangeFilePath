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
using System.IO;

namespace ChangeFilePath
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "请选择文件夹";
            fbd.ShowDialog();
            this.text1.Text = fbd.SelectedPath;//存储文件的路径信息
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "请选择文件夹";
            fbd.ShowDialog();
            this.text2.Text = fbd.SelectedPath;//存储文件的路径信息
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            DirectoryInfo root = new DirectoryInfo(text1.Text);
            FileInfo[] files = root.GetFiles("*",SearchOption.AllDirectories);
            for (int i = 0; i <= files.Length - 1; i++)
            {
                //files[i].MoveTo(text2.Text + "\\" + files[i].Name);
                files[i].MoveTo(text2.Text + "\\" + files[i].Name);
            }
        }
    }
}
