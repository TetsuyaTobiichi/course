using Npgsql;
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

namespace course
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
       List<string> favorItem = new List<string>();
        public Window2()
        {
            InitializeComponent();
            string connectionString = "Server=127.0.0.1;Port=5432;User Id=postgres;Password=476312;Database=coursework;";
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            List<string> items = new List<string>();
            using (var cmd = new NpgsqlCommand("SELECT * FROM \"table\"", connection))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        
                        items.Add(reader.GetString(0));
                        // Обработка данных
                    }
                }
            }
            foreach (string item in items)
            {
                myListBox.Items.Add(item);
            }
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (myListBox.SelectedItem != null)
            {
                string selectedItem = myListBox.SelectedItem.ToString();
               
            }
        }

        private void addToFavorites_Click(object sender, RoutedEventArgs e)
        {
            if (myListBox.SelectedItem != null)
            {
                string selectedItem = myListBox.SelectedItem.ToString();
                favorItem.Add(selectedItem);
                favorites.Items.Add(selectedItem);
            }
            //312312asdas//123
            //AJSDHKAJSD
            //asdas
           //ajkhsdkaj
        }
    }
}
