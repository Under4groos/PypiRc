using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PypiRc
{
    /// <summary>
    /// Логика взаимодействия для BButton.xaml
    /// </summary>
    public partial class BButton : UserControl
    {
        public  string Text
        {
            get { return label_c.Content as string; }
            set { label_c.Content = value;}
        }
        public BButton()
        {
            InitializeComponent();
        }
    }
}
