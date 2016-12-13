using System;
using System.ComponentModel;
using System.Text;
using System.Text.RegularExpressions;

namespace MyLessonsWpf002
{
    class RegexModel : INotifyPropertyChanged
    {
        //正则表达式的匹配检查
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(params String[] aPropertyNames)
        {
            foreach (string aPropertyName in aPropertyNames)
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(aPropertyName)));
        }

        public string _Pattern;
        public string Pattern
        {
            get { return _Pattern; }
            set
            {
                if (_Pattern == value) return;
                _Pattern = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Pattern)));
            }
        }
        private string _ReplacePattern;
        public string ReplacePattern
        {
            get { return _ReplacePattern; }
            set
            {
                if (_ReplacePattern == value) return;
                _ReplacePattern = value;
                OnPropertyChanged("ReplacePattern");
            }
        }

        private string _ReplaceResult;
        public string ReplaceResult
        {
            get { return _ReplaceResult; }
            set
            {
                if (_ReplaceResult == value) return;
                _ReplaceResult = value;
                OnPropertyChanged("ReplaceResult");
            }
        }

        private string[] _SourceText;
        public string[] SourceText
        {
            get { return _SourceText; }
            set
            {
                if (_SourceText == value) return;
                _SourceText = value;
                OnPropertyChanged("SourceText");
            }
        }

        private string _ViewText;
        public string ViewText
        {
            get { return _ViewText; }
            set
            {
                if (_ViewText == value) return;
                _ViewText = value;
                OnPropertyChanged("ViewText");
            }
        }


        public string _SampleText;
        public string SampleText
        {
            get { return _SampleText; }
            set
            {
                if (_SampleText == value) return; _SampleText = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SampleText)));
            }
        }

        private string _TestText;

        public string TestText
        {
            get { return _TestText; }
            set
            {
                if (_TestText == value) return; _TestText = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TestText)));
            }
        }

        private string _TestResult;

        public string TestResult
        {
            get { return _TestResult; }
            set
            {
                if (_TestResult == value) return; _TestResult = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TestResult)));
            }
        }

        private MatchCollection _TestResult1;
        public MatchCollection TestResult1
        {
            get { return _TestResult1; }
            set
            {
                if (_TestResult1 == value) return;
                _TestResult1 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TestResult1)));
            }
        }

        public void Test()
        {
            Regex aRegex = new Regex(Pattern);
            // TestResult = aRegex.IsMatch(SampleText)?"匹配成功":"匹配失败";
            MatchCollection aMatches=aRegex.Matches(SampleText);//多个匹配
            TestResult1= aMatches;
           /* TestResult = "";
            foreach(Match aMatch in aMatches)
            {
                TestResult += aMatch.Value + "\n";//直接拼接，实际不建议
                //aMatch.Groups//匹配内容中关心的内容，有括号部分
              //  foreach(Group aGroup in aMatch.Groups)
               // {
               //     TestResult += "   Group:" + aGroup.Value;
              //  }
                for(int i=0;i< aMatch.Groups.Count;i++)
                {
                    TestResult += "   Group:{" + i + "}" + aMatch.Groups[i].Value+"\n";
                }
            }*/
        }
        //替换
        public void Replace()
        {
            Regex aRegex = new Regex(ReplacePattern);
            ReplaceResult = aRegex.Replace(SampleText, ReplacePattern);
        }

        public void Filter()
        {
            StringBuilder aStringBuilder = new StringBuilder();
            Regex aRegex = new Regex(Pattern);
            foreach(string aLine in SourceText)
            {
                if (aRegex.IsMatch(aLine)) aStringBuilder.Append();
            }
        }
    }
}
