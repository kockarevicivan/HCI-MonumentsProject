using HCI.MonumentsProject.BL.Contracts;
using HCI.MonumentsProject.BL.Managers;
using HCI.MonumentsProject.Domain.Entities;
using HCI.MonumentsProject.Presentation.HelpFiles;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace HCI.MonumentsProject.Presentation
{
    public partial class EditTag : Window
    {
        private Tag _forEdit;
        private TagList _tagList;
        private ITagManager _tagManager;

        public EditTag(Tag tag, TagList tagList)
        {
            _tagList = tagList;
            _forEdit = tag;
            _tagManager = new TagManager();

            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;

            idTextbox.Text = _forEdit.Id;
            idTextbox.IsEnabled = false;
            colorPicker.SelectedColor = (Color)ColorConverter.ConvertFromString(tag.Color);
            descriptionTextbox.Text = _forEdit.Description;
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateFields())
            {
                Tag found = TagList.Tags.Where(t => t.Id == idTextbox.Text).FirstOrDefault();

                found.Id = idTextbox.Text;
                found.Color = colorPicker.SelectedColor.ToString();
                found.Description = descriptionTextbox.Text;

                _tagList.Repaint();

                _tagManager.Update(found);

                MessageBox.Show("Etiketa je ažurirana!");

                this.Close();
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
