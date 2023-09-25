using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5
{

    public class SelectedClass
    {
        public string name { get; set; }
        public string img { get; set; }
        public bool isSelected { get; set; }
        public SelectedClass(string name, string imgUri = "/cross.png", bool isSelected = false)
        {
            this.name = name;
            this.img = imgUri;
            this.isSelected = isSelected;
        }
    }

}
