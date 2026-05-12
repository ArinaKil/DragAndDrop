using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using System;

namespace DragAndDrop_Kilunina
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer dispatcherTimer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            dispatcherTimer.Tick += DispatcherTimer_Tick;
            dispatcherTimer.Interval = new System.TimeSpan(0, 0, 0, 0, 1000 / 60);
        }
        private void DispatcherTimer_Tick(object sender, System.EventArgs e)
        {
            image.Margin = new Thickness(Mouse.GetPosition(this).X - 25, Mouse.GetPosition(this).Y - 25, 0, 0);
        }
        private void ImageUp(object sender, MouseButtonEventArgs e)
        {
            dispatcherTimer.Stop();
        }
        private void ImageDown(object sender, MouseButtonEventArgs e)
        {
            dispatcherTimer.Start();
        }
    }
}