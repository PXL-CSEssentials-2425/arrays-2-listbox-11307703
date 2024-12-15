using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ListBox
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

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem newItem = new ListBoxItem();
            newItem.Content= txtAdd.Text;
            simpleListBox.Items.Add(newItem);

            txtAdd.Clear();
            txtAdd.Focus();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            simpleListBox.Items.Clear();
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem newItem = new ListBoxItem();
            newItem = simpleListBox.SelectedItem as ListBoxItem;
            simpleListBox.Items.Remove(newItem);

        }

        private void btnSort_Click(object sender, RoutedEventArgs e)
        {
            simpleListBox.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription("Content", System.ComponentModel.ListSortDirection.Ascending));
        }

        private void btnReplace_Click(object sender, RoutedEventArgs e)
        {
            int selectedIndex = simpleListBox.SelectedIndex;
            simpleListBox.Items[selectedIndex] = txtReplace.Text;
            txtReplace.Clear();


        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            int index = 0;
            foreach(ListBoxItem item in simpleListBox.Items)
            {
               if(item.Content.Equals(txtSearch.Text))
                {
                    index = simpleListBox.SelectedIndex;
                    break;
                }
                index++;
            }
            searchLabel.Content = $"Naam gevonden op positie:\n {index} " ;
        }
    }
}