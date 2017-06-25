using HCI.MonumentsProject.BL.Contracts;
using HCI.MonumentsProject.BL.Managers;
using HCI.MonumentsProject.Domain.Entities;
using HCI.MonumentsProject.Presentation.HelpFiles;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace HCI.MonumentsProject.Presentation
{
    public partial class TagList : Window
    {
        private ITagManager _tagManager;
        public static ObservableCollection<Tag> Tags;

        public TagList()
        {
            _tagManager = new TagManager();
            Tags = new ObservableCollection<Tag>(_tagManager.GetAll());

            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;

            tagsGrid.ItemsSource = Tags;
        }

        private void createButton_Click(object sender, RoutedEventArgs e)
        {
            NewTag newTagWindow = new NewTag();
            newTagWindow.ShowDialog();
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            if (tagsGrid.SelectedItem != null)
            {
                EditTag editTagWindow = new EditTag((Tag)tagsGrid.SelectedItem, this);
                editTagWindow.ShowDialog();
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
            if (tagsGrid.SelectedItem != null)
            {
                MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Da li ste sigurni?", "Brisanje etikete", MessageBoxButton.YesNo);
                if (messageBoxResult == MessageBoxResult.Yes)
                {
                    Tag row = (Tag)tagsGrid.SelectedItem;
                    Tags.Remove(row);
                    _tagManager.Delete(row.Id);
                }
            }
            else
            {
                MessageBox.Show("Nije selektovana ni jedna etiketa!");
            }
        }

        public void Repaint()
        {
            tagsGrid.ItemsSource = null;
            tagsGrid.ItemsSource = Tags;
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
