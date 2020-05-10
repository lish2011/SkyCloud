/*
 
 */
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

namespace Xaml_0510
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.btn_first.Content = "btnFirst";            
        }

        private void btn_first_Click(object sender, RoutedEventArgs e)
        {
            this.ucButtonTextbox.textBox.Text = this.mainGrid.Name;
            MessageBox.Show(String.Format("The Grid is {0}x{1} size units in size.", this.mainGrid.ActualWidth, this.mainGrid.ActualHeight));
        }
    }
}
