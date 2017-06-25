using HCI.MonumentsProject.BL.Contracts;
using HCI.MonumentsProject.BL.Managers;
using HCI.MonumentsProject.Domain.Entities;
using HCI.MonumentsProject.Presentation.HelpFiles;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace HCI.MonumentsProject.Presentation
{
    /// <summary>
    /// Interaction logic for Map.xaml
    /// </summary>
    public partial class Map : Window
    {
        private IMonumentManager _monumentManager;
        private IPositionManager _positionManager;
        public static ObservableCollection<Monument> Monuments;
        
        private Monument _selectedMonument;

        private Image draggedImage;
        private Point mousePosition;

        public Map()
        {
            _monumentManager = new MonumentManager();
            _positionManager = new PositionManager();

            List<Position> oldPositions = _positionManager.GetAll().ToList();
            Monuments = new ObservableCollection<Monument>(_monumentManager.GetAll().Where(m => !oldPositions.Select(op => op.MonumentId).Contains(m.Id)));

            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;

            listView.ItemsSource = Monuments;

            ImageBrush ib = new ImageBrush();
            ib.ImageSource = new BitmapImage(new Uri(@"map.png", UriKind.Relative));
            mapCanvas.Background = ib;

            

            foreach (var p in oldPositions)
            {
                Monument found = _monumentManager.GetById(p.MonumentId);

                if (found == null)
                {
                    continue;///TODO should delete
                }

                // if drag started from listview
                Image icon = new Image()
                {
                    Source = new BitmapImage(new Uri(found.IconPath, UriKind.RelativeOrAbsolute)),
                    Name = found.Id,
                    Width = 60,
                    Height = 60
                };

                mapCanvas.Children.Add(icon);

                Canvas.SetLeft(icon, p.XPosition);
                Canvas.SetTop(icon, p.YPosition);
            }

        }
        
        private void ListViewItem_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            _selectedMonument = (Monument)((ListViewItem)sender).Content;
            
            e.Handled = true;
            return;
        }

        private void canvas_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Point p = e.GetPosition(this);
            double x = p.X;
            double y = p.Y;

            if (draggedImage != null)
            {
                // if drag started from canvas
                mapCanvas.ReleaseMouseCapture();
                Panel.SetZIndex(draggedImage, 0);
                draggedImage = null;

                WriteCanvasPositions();
            }
            else if (_selectedMonument != null)
            {
                // if drag started from listview
                Image icon = new Image()
                {
                    Source = new BitmapImage(new Uri(_selectedMonument.IconPath, UriKind.RelativeOrAbsolute)),
                    Name = _selectedMonument.Id,
                    Width = 60,
                    Height = 60
                };

                mapCanvas.Children.Add(icon);

                Canvas.SetLeft(icon, x-10);
                Canvas.SetTop(icon, y-22);

                Monuments.Remove(_selectedMonument);
                _selectedMonument = null;

                WriteCanvasPositions();
            }
        }

        private void canvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var image = e.Source as Image;

            if (image != null && mapCanvas.CaptureMouse())
            {
                mousePosition = e.GetPosition(mapCanvas);
                draggedImage = image;
                Panel.SetZIndex(draggedImage, 1); // in case of multiple images
            }
        }
        
        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (draggedImage != null)
            {
                var position = e.GetPosition(mapCanvas);
                var offset = position - mousePosition;
                mousePosition = position;
                Canvas.SetLeft(draggedImage, Canvas.GetLeft(draggedImage) + offset.X);
                Canvas.SetTop(draggedImage, Canvas.GetTop(draggedImage) + offset.Y);
            }
        }
        
        private void button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void WriteCanvasPositions()
        {
            List<Position> oldPositions = _positionManager.GetAll().ToList();

            foreach (var c in mapCanvas.Children)
            {
                if (c is Image)
                {
                    Image img = (Image)c;

                    if (oldPositions.Where(p => p.MonumentId == img.Name).FirstOrDefault() == null)
                    {
                        //doesn't exist - create
                        _positionManager.Create(new Position() {
                            XPosition = (float)Canvas.GetLeft((UIElement)c),
                            YPosition = (float)Canvas.GetTop((UIElement)c),
                            MonumentId = img.Name
                        });
                    }
                    else
                    {
                        //does already exist - update
                        _positionManager.Update(new Position()
                        {
                            XPosition = (float)Canvas.GetLeft((UIElement)c),
                            YPosition = (float)Canvas.GetTop((UIElement)c),
                            MonumentId = img.Name
                        });
                    }
                }
            }
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
