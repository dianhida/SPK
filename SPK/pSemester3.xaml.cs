﻿using System;
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
    /// Interaction logic for pSemester3.xaml
    /// </summary>
    public partial class pSemester3 : UserControl
    {
        public pSemester3()
        {
            InitializeComponent();
        }

        private void bTerus3_Click(object sender, RoutedEventArgs e)
        {
            Temper.semester = "4";
            Switcher.Switch(new ucSemester4());
        }

        private void cbModsim_GotFocus(object sender, RoutedEventArgs e)
        {
            cbModsim.Opacity = 100;
        }

        private void cbModsim_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbModsim.Text))
            {
                cbModsim.Opacity = 0;
            }
            else
                cbModsim.Opacity = 100;
        }

        private void cbJarkomdat_GotFocus(object sender, RoutedEventArgs e)
        {
            cbJarkomdat.Opacity = 100;
        }

        private void cbJarkomdat_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbModsim.Text))
            {
                cbJarkomdat.Opacity = 0;
            }
            else
                cbJarkomdat.Opacity = 100;
        }

        private void cbSismik_GotFocus(object sender, RoutedEventArgs e)
        {
            cbSismik.Opacity = 100;
        }

        private void cbSismik_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbModsim.Text))
            {
                cbSismik.Opacity = 0;
            }
            else
                cbSismik.Opacity = 100;
        }

        private void cbBasisData_GotFocus(object sender, RoutedEventArgs e)
        {
            cbBasisData.Opacity = 100;
        }

        private void cbBasisData_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbModsim.Text))
            {
                cbBasisData.Opacity = 0;
            }
            else
                cbBasisData.Opacity = 100;
        }

        private void cbSisop_GotFocus(object sender, RoutedEventArgs e)
        {
            cbSisop.Opacity = 100;
        }

        private void cbSisop_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbModsim.Text))
            {
                cbSisop.Opacity = 0;
            }
            else
                cbSisop.Opacity = 100;
        }
    }
}
