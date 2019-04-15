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

       //Кнопка 
        private void BtnMessageBox_Click(object sender, RoutedEventArgs e)
        {
          
            string temp = textl.Text;
            MessageBox.Show("Доб окно");
            MessageBox.Show(temp);

        }

        private void GetInput_Click(object sender, RoutedEventArgs e)
        {
           // var myProsses = new Process();


            string dateImputUser = textl.Text.Trim();

            if (dateImputUser !="" || dateImputUser != null|| dateImputUser != "." )
            {
                MessageBox.Show($"Были введены текущие данные: \t\n{dateImputUser}");
                //MessageBox.Show("Не коректные данные");
            }
            //MessageBox.Show($"Были введены текущие данные: \t\n{dateImputUser}");
            // MessageBox.Show($"Имя машины: \t\n{myProsses.MachineName}");
            else
            { 
            MessageBox.Show("Не коректные данные");
            }
        }
    }
}
