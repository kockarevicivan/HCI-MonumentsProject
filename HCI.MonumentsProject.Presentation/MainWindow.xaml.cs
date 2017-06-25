using HCI.MonumentsProject.Presentation.HelpFiles;
using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace HCI.MonumentsProject.Presentation
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;

            imageLogo.Source = new BitmapImage(new Uri(@"Resources/Images/monumentsLogo.png", UriKind.Relative));
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void monumentListButton_Click(object sender, RoutedEventArgs e)
        {
            MonumentList monumentListWindow = new MonumentList();
            monumentListWindow.Show();
            this.Close();
        }

        private void mapButton_Click(object sender, RoutedEventArgs e)
        {
            Map mapWindow = new Map();
            mapWindow.Show();
            this.Close();
        }

        private void tagListbutton_Click(object sender, RoutedEventArgs e)
        {
            TagList tagListWindow = new TagList();
            tagListWindow.Show();
            this.Close();
        }

        private void monumentTypeListButton_Click(object sender, RoutedEventArgs e)
        {
            MonumentTypeList monumentTypeListWindow = new MonumentTypeList();
            monumentTypeListWindow.Show();
            this.Close();
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
