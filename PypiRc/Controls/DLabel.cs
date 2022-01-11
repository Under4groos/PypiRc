using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace PypiRc.Controls
{
    internal class DLabel : Label
    {
        public DLabel()
        {
            this.Foreground = System.Windows.Media.Brushes.White;
            this.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            this.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
        }
    }
}
