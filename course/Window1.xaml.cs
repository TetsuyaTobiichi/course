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
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            answer1.Content = "123";
            if ((bool)answer1.IsChecked)
            {
                
                correctAnswer ++;
                //123
                answer1.Content = "333";
                answer2.Content = correctAnswer;
            }
        }
    }
}