using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MvvmEditTable
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public RowEditCommand rowEditCommand { get; private set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public TableRows tableRows;
        private ObservableCollection<TableRow> tableData = new ObservableCollection<TableRow>();

        public ObservableCollection<TableRow> TableData {
            get { return tableData; }
            set 
            {
                OnPropertyChanged(nameof(TableData));
            }
        }

        public MainWindowViewModel()
        {
            rowEditCommand = new RowEditCommand(this);

            tableRows = new TableRows();
            tableData = tableRows.InitializeTable();
        }

        public void OnPropertyChanged(string parameter = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(parameter));
        }
    }
}
