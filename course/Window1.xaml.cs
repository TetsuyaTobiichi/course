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
using System.Windows.Shapes;
using Npgsql;

namespace course
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        int correctAnswer = 0;
        
        public Window1()
        {
           /* string connectionString = "Server=127.0.0.1;Port=5432;User Id=postgres;Password=your_password;Database=your_database;";
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();*/
            InitializeComponent();
            end.Visibility = Visibility.Hidden;
            rate.Visibility = Visibility.Hidden;
        }
        public int Result(int correctAswer,int answerCount)
        {
            return answerCount / correctAswer;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            answer1.Visibility = Visibility.Hidden;
            answer2.Visibility = Visibility.Hidden;
            answer3.Visibility = Visibility.Hidden;
            next.Visibility= Visibility.Hidden;
            end.Visibility = Visibility.Visible;
            rate.Visibility = Visibility.Visible;
        }

        private void end_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
