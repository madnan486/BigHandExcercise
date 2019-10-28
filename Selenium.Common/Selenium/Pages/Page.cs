using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Common.Selenium.Pages
{
    public abstract class Page
    {
        public string Name { get; set; }

        public Page(string name)
        {
            Name = name;
        }
    }
}
