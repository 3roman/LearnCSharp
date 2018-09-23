using System.ComponentModel;
using System.Collections.Generic;
using Commander;
using MVVMDemo.Proxy;  // 读取数据
using MVVMDemo.DTO;  // 定义模型


namespace MVVMDemo.ViewModel
{
    class VMWindowMain : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public List<Student> students { get; set; }
        public Student student { get; set; }
        private int index = 0;

        public VMWindowMain()
        {
            students = GetData.GetStudentInfo();
        }

        [OnCommand("ReadStudentInfo")]
        public void ReadStudentInfo()
        {
            student = students[index];

            if (index < students.Count-1)
            {
                index++;
            }
            else
            {
                index = 0;
            }
        }
    }
}
