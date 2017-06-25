using HCI.MonumentsProject.BL.Contracts;
using HCI.MonumentsProject.BL.Managers;
using HCI.MonumentsProject.Domain.Entities;
using HCI.MonumentsProject.Presentation.HelpFiles;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace HCI.MonumentsProject.Presentation
{
    public partial class NewTag : Window
    {
        private ITagManager _tagManager;

        public NewTag()
        {
            _tagManager = new TagManager();

            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void createButton_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateFields())
            {
                if (!TagList.Tags.Select(t => t.Id).Contains(idTextbox.Text))
                {
                    Tag newTag = new Tag()
                    {
                        Id = idTextbox.Text,
                        Color = colorPicker.SelectedColor.ToString(),
                        Description = descriptionTextbox.Text
                    };

                    TagList.Tags.Add(newTag);
                    _tagManager.Create(newTag);

                    MessageBox.Show("Tag uspešno kreiran!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tag sa tim id-em već postoji!");
                }
            }
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrEmpty(idTextbox.Text))
            {
                MessageBox.Show("Id ne sme biti prazan!");
                return false;
            }
            else if (string.IsNullOrEmpty(colorPicker.SelectedColor.ToString()))
            {
                MessageBox.Show("Boja mora biti selektovana!");
                return false;
            }

            return true;
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
