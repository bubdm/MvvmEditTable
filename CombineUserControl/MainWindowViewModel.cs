using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace CombineUserControl
{
    public class TabItemData
    {
        public string Header { get; set; }
        public Visibility TextMode { get; set; }
        public Visibility ApplyButtonMode { get; set; }
        public Visibility AddButtonMode { get; set; }
        public bool isForeTab { get; set; } = true;
        public UserControlAViewModel VMA { get; set; }
    }

    class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<TabItemData> tabItemDataCollection { get; set; } = new ObservableCollection<TabItemData>();

        public MainWindowViewModel()
        {
            CreateTabItem();
        }

        private void CreateTabItem()
        {
            tabItemDataCollection.Add(new TabItemData()
            {
                Header = "",
                TextMode = Visibility.Visible,
                ApplyButtonMode = Visibility.Visible,
                AddButtonMode = Visibility.Collapsed,
                VMA = new UserControlAViewModel()
            });
            tabItemDataCollection.Add(new TabItemData()
            {
                Header = "",
                TextMode = Visibility.Visible,
                ApplyButtonMode = Visibility.Visible,
                AddButtonMode = Visibility.Collapsed,
                VMA = new UserControlAViewModel()
            });
            tabItemDataCollection.Add(new TabItemData()
            {
                Header = "",
                TextMode = Visibility.Collapsed,
                ApplyButtonMode = Visibility.Collapsed,
                AddButtonMode = Visibility.Visible,
                VMA = new UserControlAViewModel()
            });
        }

        public void OnPropertyChanged(string parameter = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(parameter));
        }

    }
}
