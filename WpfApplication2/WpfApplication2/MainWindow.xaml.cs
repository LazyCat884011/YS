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

namespace WpfApplication2
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {

            Todod todo = new Todod();
            TodoList.Children.Add(todo);
        }

        private void SaveBtn_MouseDown(object sender, RoutedEventArgs e)
        {
            List<string> all = new List<string>();
            string data = "";
            foreach (Todod item in TodoList.Children)
            {
                data += item.ItemName + "\r\n";
            }
            // 存檔
            System.IO.File.WriteAllText(@"C:\temp\data.txt", data);


        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            List<string> all = new List<string>();
            string data = "";
            foreach (Todod item in TodoList.Children)
            {
                if (item.IsChecked == true)
                    data += "+";
                else
                    data += "-";
                // 文字
                data += "|" + item.ItemName + "\r\n";
            }
            // 存檔
            System.IO.File.WriteAllText(@"C:\temp\data.txt", data);

        }
    }
}
