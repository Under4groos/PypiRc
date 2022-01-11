using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PypiRc.Controls
{
    public static class ControlsLib
    {
        public static void HidePanels(FrameworkElement[] frameworkElements , FrameworkElement frameworkElement)
        {
            foreach (var element in frameworkElements)
            {
                if (element == frameworkElement)
                    element.Visibility = Visibility.Visible;
                element.Visibility = Visibility.Hidden;
            }
        }
    }
}
