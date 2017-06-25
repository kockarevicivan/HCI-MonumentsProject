using HCI.MonumentsProject.BL.Contracts;
using HCI.MonumentsProject.BL.Managers;
using HCI.MonumentsProject.Commons;
using HCI.MonumentsProject.Domain.Entities;
using HCI.MonumentsProject.Presentation.HelpFiles;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace HCI.MonumentsProject.Presentation
{
    public partial class NewMonument : Window, INotifyPropertyChanged
    {
        private string _name;
        private string _revenue;
        private string _iconPath;
        private OpenFileDialog _fileDialog;
        private IMonumentManager _monumentManager;
        private IMonumentTypeManager _mounmentTypeManager;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        public string Ime
        {
            get { return _name; }
            set
            {
                if (value != _name)
                {
                    _name = value;
                    OnPropertyChanged("Ime");
                }
            }
        }

        public string Prihod
        {
            get { return _revenue; }
            set
            {
                if (value != _revenue)
                {
                    _revenue = value;
                    OnPropertyChanged("Prihod");
                }
            }
        }

        public NewMonument()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;

            this.DataContext = this;
            this._fileDialog = new OpenFileDialog();
            _fileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            _monumentManager = new MonumentManager();
            _mounmentTypeManager = new MonumentTypeManager();

            foreach (string era in Constants.MonumentEras)
            {
                eraCombobox.Items.Add(era);
            }

            foreach (string status in Constants.TouristStatuses)
            {
                statusCombobox.Items.Add(status);
            }

            List<MonumentType> monumentTypes = _mounmentTypeManager.GetAll().ToList();

            foreach (var type in monumentTypes)
            {
                monumentType.Items.Add(type.Id);
            }
        }

        private void createButton_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateFields())
            {
                if (!MonumentList.Monuments.Select(m => m.Id).Contains(idTextbox.Text))
                {
                    Monument newMonument = new Monument()
                    {
                        Id = idTextbox.Text,
                        Name = nameTextbox.Text,
                        Description = descriptionTextbox.Text,
                        MonumentTypeId = monumentType.Text,
                        MonumentEra = eraCombobox.Text,
                        IconPath = _fileDialog.FileName,
                        IsArchaeologicallyProcessed = (bool)isProcessedCheck.IsChecked,
                        IsOnUNESCOList = (bool)isUnescoCheck.IsChecked,
                        IsInPopulatedArea = (bool)isInPopulatedCheck.IsChecked,
                        TouristStatus = statusCombobox.Text,
                        YearIncome = float.Parse(annualRevenueTextbox.Text),
                        DateOfDiscovery = (DateTime)revealedDatePicker.SelectedDate
                    };

                    MonumentList.Monuments.Add(newMonument);
                    _monumentManager.Create(newMonument);

                    MessageBox.Show("Spomenik je dodat!");

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Spomenik sa tim id-em već postoji!");
                }
            }
        }

        private void iconButton_Click(object sender, RoutedEventArgs e)
        {
            if (_fileDialog.ShowDialog() == true)
            {
                _iconPath = _fileDialog.FileName;
                iconImage.Source = new BitmapImage(new Uri(_iconPath, UriKind.RelativeOrAbsolute));
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
            else if (monumentType.SelectedIndex == -1)
            {
                MessageBox.Show("Tip mora biti selektovan!");
                return false;
            }
            else if (eraCombobox.SelectedIndex == -1)
            {
                MessageBox.Show("Era mora biti selektovana!");
                return false;
            }
            else if (string.IsNullOrEmpty(_iconPath))
            {
                MessageBox.Show("Ikonica mora biti selektovana!");
                return false;
            }
            else if (string.IsNullOrEmpty(annualRevenueTextbox.Text))
            {
                MessageBox.Show("Prihod ne sme biti prazan!");
                return false;
            }
            else if (statusCombobox.SelectedIndex == -1)
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
