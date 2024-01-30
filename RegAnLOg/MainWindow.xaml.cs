﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RegAnLOg
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_Log(object sender, RoutedEventArgs e)
        {
            Log log = new();
            log.Show();
        }

        private void Button_Click_Reg(object sender, RoutedEventArgs e)
        {
            Reg reg = new();
            reg.Show();
        }
    }
}