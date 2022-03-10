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
using SchoolSchedule;
using static SchoolSchedule.Class1;

namespace WpfPres
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string[] students = { "Ваня", "Аня", "Поля", "Коля", "Андерсон" };

            Class1 cls = new Class1();
           
            Students.ItemsSource = students;

        }    
    }
}
