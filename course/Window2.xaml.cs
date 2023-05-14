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
            List<string> items = new List<string>() { "Item 1", "Item 2", "Item 3", "Item 4", "Item 5", "Item 6", "Item 7", "Item 8", "Item 9", "Item 10" };
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
           
        }
    }
}
