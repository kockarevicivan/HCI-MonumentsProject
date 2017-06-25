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
    public partial class NewMonumentType : Window
    {
        private OpenFileDialog _fileDialog;
        private string _iconPath;
        private IMonumentTypeManager _monumentTypeManager;

        public NewMonumentType()
        {
            this._fileDialog = new OpenFileDialog();
            _fileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            _monumentTypeManager = new MonumentTypeManager();

            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void iconButton_Click(object sender, RoutedEventArgs e)
        {
            if (_fileDialog.ShowDialog() == true)
            {
                _iconPath = _fileDialog.FileName;
                iconImage.Source = new BitmapImage(new Uri(_iconPath, UriKind.RelativeOrAbsolute));
            }
        }

        private void createButton_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateFields())
            {
                if (!MonumentTypeList.MonumentTypes.Select(mt => mt.Id).Contains(idTextbox.Text))
                {
                    MonumentType type = new MonumentType()
                    {
                        Id = idTextbox.Text,
                        Name = nameTextbox.Text,
                        IconPath = _iconPath,
                        Description = descriptionTextbox.Text
                    };

                    MonumentTypeList.MonumentTypes.Add(type);
                    _monumentTypeManager.Create(type);

                    MessageBox.Show("Tip spomenika je dodat!");

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tip spomenika sa tim id-em već postoji!");
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
