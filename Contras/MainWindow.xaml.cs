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

// https://wpf-tutorial.com/es/4/comenzando/hola-wpf/
// https://wpf-tutorial.com/es/6/xaml/xaml-basico/
// WPF
// XAML eXtensible Application Markup Language

namespace Contras
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void mnuSalir_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
