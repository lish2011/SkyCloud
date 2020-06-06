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

namespace WPFCommand
{
    /// <summary>
    /// UcWithCommand.xaml 的交互逻辑
    /// </summary>
    public partial class UcWithCommand : UserControl
    {
        public UcWithCommand()
        {
            InitializeComponent();
        }

        private void RequeryCommand_Execute(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Requery");
        }
    }

    // 自定义命令
    public class DataCommands
    {
        private static RoutedUICommand requeryCommand;
        static DataCommands()
        {
            InputGestureCollection inputs = new InputGestureCollection();
            inputs.Add(new KeyGesture(Key.R, ModifierKeys.Control, "Ctrl+R"));      // 快捷键
            requeryCommand = new RoutedUICommand("RequeryText", "Requery", typeof(CustomCommands), inputs);
        }

        public static RoutedUICommand Requery
        {
            get { return requeryCommand; }
        }
    }
}
