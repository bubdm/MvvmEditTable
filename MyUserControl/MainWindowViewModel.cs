using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MyUserControl
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string input = "DefaultText";
        public string Input
        {
            get { return input; }
            set
            {
                input = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(Input)));
            }
        }
    }
}
