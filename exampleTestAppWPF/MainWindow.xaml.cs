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
using System.Diagnostics;

namespace exampleTestAppWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Process myProsses = new Process();
        public MainWindow()
        {
            InitializeComponent();
           
            //меняем настройки по умолчанию
            // this.Title = "testProga";
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen; //устанавливаем локацию запуска программы
        }

        private void OpenNewFile_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CreateNewFile_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ExitApp_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SaveNewFile_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
