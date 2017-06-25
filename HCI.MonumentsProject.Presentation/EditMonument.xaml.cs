using HCI.MonumentsProject.BL.Contracts;
using HCI.MonumentsProject.BL.Managers;
using HCI.MonumentsProject.Commons;
using HCI.MonumentsProject.Domain.Entities;
using HCI.MonumentsProject.Presentation.HelpFiles;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace HCI.MonumentsProject.Presentation
{
    public partial class EditMonument : Window
    {
        private Monument _forEdit;
        private MonumentList _monumentList;
        private string _iconPath;
        private OpenFileDialog _fileDialog;
        private IMonumentTypeManager _mounmentTypeManager;
        private IMonumentManager _monumentManager;

        public EditMonument(Monument monument, MonumentList monumentList)
        {
            _monumentList = monumentList;
            _monumentManager = new MonumentManager();
            _forEdit = monument;
            _fileDialog = new OpenFileDialog();
            _fileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            _mounmentTypeManager = new MonumentTypeManager();

            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;

            foreach (string era in Constants.MonumentEras)
            {
                eraDropdown.Items.Add(era);
            }

            foreach (string status in Constants.TouristStatuses)
            {
                touristDropdown.Items.Add(status);
            }

            List<MonumentType> monumentTypes = _mounmentTypeManager.GetAll().ToList();

            foreach (var type in monumentTypes)
            {
                typeDropdown.Items.Add(type.Id);
            }

            eraDropdown.SelectedValue = _forEdit.MonumentEra;
            touristDropdown.SelectedValue = _forEdit.TouristStatus;
            typeDropdown.SelectedValue = _forEdit.MonumentTypeId;

            idTextbox.Text = _forEdit.Id;
            idTextbox.IsEnabled = false;
            nameTextbox.Text = _forEdit.Name;
            descriptionTextbox.Text = _forEdit.Description;
            _iconPath = _forEdit.IconPath;
            iconImage.Source = new BitmapImage(new Uri(_iconPath, UriKind.RelativeOrAbsolute));
            revenueTextbox.Text = _forEdit.YearIncome.ToString();
            isProcessedCheck.IsChecked = _forEdit.IsArchaeologicallyProcessed;
            isUnescoCheck.IsChecked = _forEdit.IsOnUNESCOList;
            isInPopulatedCheck.IsChecked = _forEdit.IsInPopulatedArea;
            revealedDatePicker.SelectedDate = _forEdit.DateOfDiscovery;
        }

        private void iconButton_Click(object sender, RoutedEventArgs e)
        {
            if (_fileDialog.ShowDialog() == true)
            {
                _iconPath = _fileDialog.FileName;
                iconImage.Source = new BitmapImage(new Uri(_iconPath, UriKind.RelativeOrAbsolute));
            }
        }

        private void updateButon_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateFields())
            {
                Monument found = MonumentList.Monuments.Where(m => m.Id == idTextbox.Text).FirstOrDefault();

                found.Id = idTextbox.Text;
                found.Name = nameTextbox.Text;
                found.Description = descriptionTextbox.Text;
                found.MonumentTypeId = typeDropdown.Text;
                found.MonumentEra = eraDropdown.Text;
                found.IconPath = String.IsNullOrEmpty(_fileDialog.FileName) ? _iconPath : _fileDialog.FileName;
                found.IsArchaeologicallyProcessed = (bool)isProcessedCheck.IsChecked;
                found.IsOnUNESCOList = (bool)isUnescoCheck.IsChecked;
                found.IsInPopulatedArea = (bool)isInPopulatedCheck.IsChecked;
                found.TouristStatus = touristDropdown.Text;
                found.YearIncome = float.Parse(revenueTextbox.Text);
                found.DateOfDiscovery = (DateTime)revealedDatePicker.SelectedDate;

                _monumentList.Repaint();

                _monumentManager.Update(found);

                MessageBox.Show("Spomenik je ažuriran!");

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
            else if (typeDropdown.SelectedIndex == -1)
            {
                MessageBox.Show("Tip mora biti selektovan!");
                return false;
            }
            else if (eraDropdown.SelectedIndex == -1)
            {
                MessageBox.Show("Era mora biti selektovana!");
                return false;
            }
            else if (string.IsNullOrEmpty(_iconPath))
            {
                MessageBox.Show("Ikonica mora biti selektovana!");
                return false;
            }
            else if (string.IsNullOrEmpty(revenueTextbox.Text))
            {
                MessageBox.Show("Prihod ne sme biti prazan!");
                return false;
            }
            else if (touristDropdown.SelectedIndex == -1)
            {
                MessageBox.Show("Turistički status mora biti selektovan!");
                return false;
            }
            else if (revealedDatePicker.SelectedDate == null)
            {
                MessageBox.Show("Datum otkrivanja ne sme biti prezan!");
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
