using System.Windows;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace WPFTest
{
    /// <summary>
    /// 数据项
    /// </summary>
    public class DataItem
    {
        public int Value { get; set; }
        public DataItem(int val) { Value = val; }
    }
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // 选中数据
            SelectedList.Add(new DataItem(1)); SelectedList.Add(new DataItem(2));
            // 可选数据
            SelectionList.Add(1); SelectionList.Add(2); SelectionList.Add(3);
        }

        /// <summary>
        /// 选中的数据列表
        /// </summary>
        public ObservableCollection<DataItem> SelectedList
        {
            get { return _selectedList; }
            set { _selectedList = value; }
        }
        private ObservableCollection<DataItem> _selectedList = new ObservableCollection<DataItem>();

        /// <summary>
        /// 可供选择的数据列表
        /// </summary>        
        public ObservableCollection<int> SelectionList
        {
            get { return _selectionList; }
            set { _selectionList = value; }
        }
        private ObservableCollection<int> _selectionList = new ObservableCollection<int>();

        // 显示选中的
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TBX_Selected.Text = "";
            foreach (var item in SelectedList)
                TBX_Selected.Text += item.Value.ToString(" --->0<--- ");
        }

    }
}
