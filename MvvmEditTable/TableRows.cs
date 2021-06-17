using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmEditTable
{
    public class TableRow
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class TableRows
    {
        public TableRows()
        {
        }

        public ObservableCollection<TableRow> InitializeTable()
        {
            ObservableCollection<TableRow> tableData = new ObservableCollection<TableRow>()
            {
                new TableRow(){ Id = 1, Name = "Tanaka", Age = 20 },
                new TableRow(){ Id = 2, Name = "Sato", Age = 21},
                new TableRow(){ Id = 3, Name = "Suzuki", Age = 22}
            };

            return tableData;
        }
    }
}
