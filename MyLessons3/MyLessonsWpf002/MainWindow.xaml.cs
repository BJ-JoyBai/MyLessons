using Microsoft.Win32;
using System;
using System.IO;
using System.Text;
using System.Windows;

namespace MyLessonsWpf002
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private RegexModel _Model;
        public MainWindow()
        {
            InitializeComponent();
            _Model = new RegexModel();
            this.DataContext = _Model;
        }

        private void OnTest_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _Model.Test();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OnLoadSampleText_Click(object sender, RoutedEventArgs e)
        {
            // _Model.LoadSample();
            //前台选择文件操作，不放后台处理
            try//异步事件响应。顶层事件需要加异常处理
            {
            OpenFileDialog aDlg = new OpenFileDialog();
            aDlg.Title = "选择样本文件";
            aDlg.Filter = "文本文件(.txt)|*.txt|所有文件(*.*)|*.*";
            if (aDlg.ShowDialog() != true) return;
            _Model.SampleText = File.ReadAllText(aDlg.FileName,Encoding.Default);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void OnReplace_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _Model.Replace();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //保存样本、匹配结果、替换结果
        private void SomeApis()
        {
            
            SaveFileDialog aDlg = new SaveFileDialog();
            if (aDlg.ShowDialog() != true) return;

            string aText = "要保存的文本";
            File.WriteAllText(aDlg.FileName,aText);
        }

        private void OnSaveReplace_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SaveFileDialog aDlg = new SaveFileDialog();
                if (aDlg.ShowDialog() != true) return;

               // string aText = "要保存的文本";
                File.WriteAllText(aDlg.FileName, _Model.ReplaceResult);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OnSave_Executed(object sender, System.Windows.Input.ExecutedRoutedEventArgs e)
        {
            try
            {
                SaveFileDialog aDlg = new SaveFileDialog();
                if (aDlg.ShowDialog() != true) return;
                File.WriteAllText(aDlg.FileName, e.Parameter as string);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OnSave_CanExecute(object sender, System.Windows.Input.CanExecuteRoutedEventArgs e)
        {
            //e.CanExecute = e.Parameter as string != null;
            e.CanExecute = !string.IsNullOrWhiteSpace(e.Parameter as string);
        }
    }
}
