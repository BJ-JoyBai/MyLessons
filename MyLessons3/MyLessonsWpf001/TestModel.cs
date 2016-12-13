using System.ComponentModel;

namespace MyLessonsWpf001
{
    //接口实现，声明属性发生变化，通知前台，发生变化的属性名
    class TestModel:INotifyPropertyChanged
    {
        // public string Value { get; set; } = "数据模型的初始数值";
        //  public int Data1 { get; set; }
        //  public int Data2 { get; set; }
        public int _Data1;
        public int Data1
        {
            get { return _Data1; }
            set
            {
                if (_Data1 == value) return;
                _Data1 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Data1"));//Result值发生改变，通知前台页面
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Result"));//Result值发生改变，通知前台页面
            }
        }

        public int _Data2;
        public int Data2
        {
            get { return _Data2; }
            set
            {
                if (_Data2 == value) return;
                _Data2 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Data2"));//Result值发生改变，通知前台页面
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Result"));//Result值发生改变，通知前台页面
            }
        }

        public int _Result;
        public int Result
        {
           // get { return _Result; }
           get//实时计算
            {
                if (CurrentOperator == null) return 0;
                return CurrentOperator.Calc(Data1,Data2);
            }
          //  set
          //  {
                //if (_Result == value) return;
                //_Result = value;
               // PropertyChanged.Invoke(this,new PropertyChangedEventArgs("Result"));//Result值发生改变，通知前台页面
           // }
        }
       
        public event PropertyChangedEventHandler PropertyChanged;
        public IOperator[] Operators { get; } = new IOperator[]
        {
            new Operator_Add(),
            new Operator_Sub(),
            new OPerator_Mul(),
            new Operator_Div()
        };

        public IOperator _CurrentOperator;
        public IOperator CurrentOperator
        {
            get { return _CurrentOperator; }
            set
            {
                if (_CurrentOperator == value) return;
                _CurrentOperator = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentOperator"));//Result值发生改变，通知前台页面
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Result"));//Result值发生改变，通知前台页面
            }
        }
      //  public void Calc(IOperator aOperator)
      //  {
      //      Result=aOperator.Calc(Data1,Data2);
      //  }
    }

    interface IOperator
    {
        string Operator { get; }
        int Calc(int aData1, int aData2);
    }
    class Operator_Add : IOperator
    {
        public string Operator
        {
            get
            {
                return "+";
            }
        }

        public int Calc(int aData1, int aData2)
        {
            return aData1 + aData2;
        }
    }
    class Operator_Sub: IOperator
    {
        public string Operator
        {
            get
            {
                return "-";
            }
        }

        public int Calc(int aData1, int aData2)
        {
            return aData1 - aData2;
        }
    }
    class OPerator_Mul : IOperator
    {
        public string Operator
        {
            get
            {
                return "*";
            }
        }

        public int Calc(int aData1, int aData2)
        {
            return aData1 * aData2;
        }
    }
    class Operator_Div : IOperator
    {
        public string Operator
        {
            get
            {
                return "/";
            }
        }

        public int Calc(int aData1, int aData2)
        {
            return aData1 / aData2;
        }
    }

}
