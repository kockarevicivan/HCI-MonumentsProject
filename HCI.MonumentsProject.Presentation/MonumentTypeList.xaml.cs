using HCI.MonumentsProject.BL.Contracts;
using HCI.MonumentsProject.BL.Managers;
using HCI.MonumentsProject.Domain.Entities;
using HCI.MonumentsProject.Presentation.HelpFiles;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace HCI.MonumentsProject.Presentation
{
    /// <summary>
    /// Interaction logic for MonumentTypeList.xaml
    /// </summary>
    public partial class MonumentTypeList : Window
    {
        private IMonumentTypeManager _monumentTypeManager;
        public static ObservableCollection<MonumentType> MonumentTypes;

        public MonumentTypeList()
        {
            _monumentTypeManager = new MonumentTypeManager();
            MonumentTypes = new ObservableCollection<MonumentType>(_monumentTypeManager.GetAll());

            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;

            monumentTypesGrid.ItemsSource = MonumentTypes;
        }

        private void createButton_Click(object sender, RoutedEventArgs e)
        {
            NewMonumentType newMonumentTypeWindow = new NewMonumentType();
            newMonumentTypeWindow.ShowDialog();
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            if (monumentTypesGrid.SelectedItem != null)
            {
                EditMonumentType editMonumentTypeWindow = new EditMonumentType((MonumentType)monumentTypesGrid.SelectedItem, this);
                editMonumentTypeWindow.ShowDialog();
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
            if (monumentTypesGrid.SelectedItem != null)
            {
                MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Da li ste sigurni?", "Brisanje tipa spomenika", MessageBoxButton.YesNo);
                if (messageBoxResult == MessageBoxResult.Yes)
                {
                    MonumentType row = (MonumentType)monumentTypesGrid.SelectedItem;
                    MonumentTypes.Remove(row);
                    _monumentTypeManager.Delete(row.Id);
                }
            }
            else
            {
                MessageBox.Show("Nije selektovan ni jedan spomenik!");
            }
        }

        public void Repaint()
        {
            monumentTypesGrid.ItemsSource = null;
            monumentTypesGrid.ItemsSource = MonumentTypes;
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
