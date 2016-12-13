using System.Windows;
using System.Windows.Input;

namespace MyLessonsWpf001
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

        private void OnTest_Click(object sender, RoutedEventArgs e)
        {
            //  MessageBox.Show(_Model.Value);
            // _Model.Calc();
            // MessageBox.Show($"结果：{_Model.Result}");
            //IOperator aOperator = cboOperators.SelectedItem as IOperator;
            //if (aOperator == null) return;
            // _Model.Calc(aOperator);
        //    if (_Model.CurrentOperator == null) return;
        //    _Model.Calc(_Model.CurrentOperator);

        }
        //路由命令，共享同一命令
        private void OnCalc_Executed(object sender, ExecutedRoutedEventArgs e)
        {
           // if (e.Parameter as IOperator == null) return;//参数是否还未选择，运算符没有给，要给定运算符才能操作
         //   _Model.Calc(e.Parameter as IOperator);

        }
        //设定必须在选择运算之后才可以点击运算按钮
        private void OnCalc_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            // e.CanExecute = true;//这个命令是否可以触发
            e.CanExecute = _Model != null && e.Parameter as IOperator != null;
        }
    }
}
