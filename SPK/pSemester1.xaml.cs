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

namespace SPK
{
    /// <summary>
    /// Interaction logic for pSemester1.xaml
    /// </summary>
    public partial class pSemester1 : UserControl
    {
        public pSemester1()
        {
            InitializeComponent();
        }

        private void bTerus1_Click (object sender, RoutedEventArgs e)
        {
            Temper.semester = "2";
            Switcher.Switch(new ucSemester2());
        }

        private void cbProgdas_GotFocus(object sender, RoutedEventArgs e)
        {
            cbProgdas.Opacity = 100;
        }

        private void cbProgdas_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbProgdas.Text))
            {
                cbProgdas.Opacity = 0;
            }
            else
                cbProgdas.Opacity = 100;
        }

        private void cbPTI_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbPTI.Text))
            {
                cbPTI.Opacity = 0;
            }
            else
                cbPTI.Opacity = 100;
        }

        private void cbPTI_GotFocus(object sender, RoutedEventArgs e)
        {
            cbPTI.Opacity = 100;
        }

        private void cbASD_GotFocus(object sender, RoutedEventArgs e)
        {
            cbASD.Opacity = 100;
        }

        private void cbASD_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbASD.Text))
            {
                cbASD.Opacity = 0;
            }
            else
                cbASD.Opacity = 100;
        }
        private void cbProbstat_GotFocus(object sender, RoutedEventArgs e)
        {
            cbProbstat.Opacity = 100;
        }

        private void cbProbstat_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbASD.Text))
            {
                cbProbstat.Opacity = 0;
            }
            else
                cbProbstat.Opacity = 100;
        }
    }
}
