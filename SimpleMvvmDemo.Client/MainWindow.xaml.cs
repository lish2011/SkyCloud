using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using SimpleMvvmDemo.Client.ViewModels;

namespace SimpleMvvmDemo.Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public void DoItWhenPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("+++++++++++DoItWhenPropertyChanged++++++++++++++++++++++");
        }

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainWindowViewModel();

            var dc = this.DataContext as MainWindowViewModel;
            dc.PropertyChanged += DoItWhenPropertyChanged;
        }
    }
}
