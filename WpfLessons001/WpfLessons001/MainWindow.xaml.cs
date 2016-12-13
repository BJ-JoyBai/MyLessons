using System.Windows;

namespace WpfLessons001
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            _Model = new TestModel();
            this.DataContext = _Model;
        }
        private TestModel _Model;
    }
}
