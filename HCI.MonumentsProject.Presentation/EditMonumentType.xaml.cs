using HCI.MonumentsProject.BL.Contracts;
using HCI.MonumentsProject.BL.Managers;
using HCI.MonumentsProject.Domain.Entities;
using HCI.MonumentsProject.Presentation.HelpFiles;
using Microsoft.Win32;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace HCI.MonumentsProject.Presentation
{
    public partial class EditMonumentType : Window
    {
        private MonumentType _forEdit;
        private MonumentTypeList _monumentTypeList;
        private OpenFileDialog _fileDialog;
        private IMonumentTypeManager _monumentTypeManager;
        private string _iconPath;

        public EditMonumentType(MonumentType monumentType, MonumentTypeList monumentTypeList)
        {
            _fileDialog = new OpenFileDialog();
            _fileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            _forEdit = monumentType;
            _monumentTypeList = monumentTypeList;
            _monumentTypeManager = new MonumentTypeManager();

            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;

            idTextbox.Text = _forEdit.Id;
            idTextbox.IsEnabled = false;
            nameTextbox.Text = _forEdit.Name;
            descriptionTextbox.Text = _forEdit.Description;
            _iconPath = _forEdit.IconPath;
            iconImage.Source = new BitmapImage(new Uri(_iconPath, UriKind.RelativeOrAbsolute));
        }

        private void iconButton_Click(object sender, RoutedEventArgs e)
        {
            if (_fileDialog.ShowDialog() == true)
            {
                _iconPath = _fileDialog.FileName;
                iconImage.Source = new BitmapImage(new Uri(_iconPath, UriKind.RelativeOrAbsolute));
            }
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateFields())
            {
                MonumentType found = MonumentTypeList.MonumentTypes.Where(mt => mt.Id == idTextbox.Text).FirstOrDefault();

                found.Id = idTextbox.Text;
                found.Name = nameTextbox.Text;
                found.Description = descriptionTextbox.Text;
                found.IconPath = String.IsNullOrEmpty(_fileDialog.FileName) ? _iconPath : _fileDialog.FileName;

                _monumentTypeList.Repaint();

                _monumentTypeManager.Update(found);

                MessageBox.Show("Tip spomenika je ažuriran!");

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
            else if (string.IsNullOrEmpty(nameTextbox.Text))
            {
                MessageBox.Show("Ime ne sme biti prazno!");
                return false;
            }
            else if (string.IsNullOrEmpty(_iconPath))
            {
                MessageBox.Show("Ikonica mora biti selektovana!");
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
