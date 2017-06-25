using HCI.MonumentsProject.BL.Contracts;
using HCI.MonumentsProject.BL.Managers;
using HCI.MonumentsProject.Domain.Entities;
using HCI.MonumentsProject.Presentation.HelpFiles;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace HCI.MonumentsProject.Presentation
{
    public partial class MonumentList : Window
    {
        private IMonumentManager _monumentManager;
        public static ObservableCollection<Monument> Monuments;

        public MonumentList()
        {
            _monumentManager = new MonumentManager();
            Monuments = new ObservableCollection<Monument>(_monumentManager.GetAll());

            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;

            monumentsGrid.ItemsSource = Monuments;
            
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            Monuments = new ObservableCollection<Monument>(_monumentManager.GetAll().Where(m => m.Id.Contains(searchBar.Text)));
            monumentsGrid.ItemsSource = null;
            monumentsGrid.ItemsSource = Monuments;
        }

        private void createButton_Click(object sender, RoutedEventArgs e)
        {
            NewMonument newMonumentWindow = new NewMonument();
            newMonumentWindow.ShowDialog();
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            if (monumentsGrid.SelectedItem != null)
            {
                EditMonument editMonumentWindow = new EditMonument((Monument)monumentsGrid.SelectedItem, this);
                editMonumentWindow.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nije selektovan ni jedan spomenik!");
            }
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void removeButton_Click(object sender, RoutedEventArgs e)
        {
            if (monumentsGrid.SelectedItem != null)
            {
                MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Da li ste sigurni?", "Brisanje spomenika", MessageBoxButton.YesNo);
                if (messageBoxResult == MessageBoxResult.Yes)
                {
                    Monument row = (Monument)monumentsGrid.SelectedItem;
                    Monuments.Remove(row);
                    _monumentManager.Delete(row.Id);
                }
            }
            else
            {
                MessageBox.Show("Nije selektovan ni jedan spomenik!");
            }
        }

        public void Repaint()
        {
            monumentsGrid.ItemsSource = null;
            monumentsGrid.ItemsSource = Monuments;
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            IInputElement focusedControl = FocusManager.GetFocusedElement(this);

            if (focusedControl == null)
            {
                focusedControl = this;
            }


            if (focusedControl is DependencyObject)
            {
                string str = HelpProvider.GetHelpKey((DependencyObject)focusedControl);
                HelpProvider.ShowHelp(str, this);
            }
        }
    }
}
