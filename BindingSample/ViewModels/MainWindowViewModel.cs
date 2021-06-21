using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingSample
{
    public class MainWindowViewModel
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public MainWindowViewModel()
        {
            Name = "Sakai";
            Address = "Toyko";
        }
    }
}
