using PypiRc.Controls;
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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PrLib.VersionPython versionPython;
        bool[] par_ = { true, false, false };
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += (o, e) =>
            {
                new WindowBlureffect(this, WindowBlureffect.AccentState.ACCENT_ENABLE_BLURBEHIND);

                versionPython = new PrLib.VersionPython();
            };
            ThreadTimer threadTimer = new ThreadTimer(this);
            threadTimer.Tick += (o, e) =>
            {
                if (par_[0])
                {
                    int count_max = 5;
                    int count_cur = 0;
                    foreach (var v in versionPython.versions)
                    {
                        if (count_max == count_cur) break;

                        UDpython uDpython = new UDpython()
                        {
                            Version = v.Ver,
                        };

                        StackPanel_panels_ver.Children.Add(uDpython);

                        count_cur++;
                    }
                    par_[0] = false;
                }
                
            };
            threadTimer.TickTime = 200;
            threadTimer.initialize();


        }
    }
}
