using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            byte[] color = new byte[3];
            rnd.NextBytes(color);

            Color randomcolor = Color.FromArgb(255, color[0], color[1], color[2]);
            SolidColorBrush brush = new SolidColorBrush(randomcolor);
            myButton1.Background = brush;
            MessageBox.Show(randomcolor.ToString(), "BU RENG", MessageBoxButton.OK, MessageBoxImage.Error);
        }


        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            byte[] color = new byte[3];
            rnd.NextBytes(color);

            Color randomcolor = Color.FromArgb(255, color[0], color[1], color[2]);
            SolidColorBrush brush = new SolidColorBrush(randomcolor);
            myButton2.Background = brush;
            MessageBox.Show(randomcolor.ToString(), "BU RENG", MessageBoxButton.OK, MessageBoxImage.Error);

        }
        private void myButton_MouseRightButtonDown1(object sender, MouseButtonEventArgs e)
        {
            Grid grid1 = (Grid)VisualTreeHelper.GetParent(myButton1);
            grid1.Children.Remove(myButton1);
        }

        private void myButton_MouseRightButtonDown2(object sender, MouseButtonEventArgs e)
        {
            Grid grid1 = (Grid)VisualTreeHelper.GetParent(myButton2);
            grid1.Children.Remove(myButton2);
        }
        private void myButton_MouseRightButtonDown3(object sender, MouseButtonEventArgs e)
        {
            Grid grid1 = (Grid)VisualTreeHelper.GetParent(myButton3);
            grid1.Children.Remove(myButton3);
        }
        private void myButton_MouseRightButtonDown4(object sender, MouseButtonEventArgs e)
        {
            Grid grid1 = (Grid)VisualTreeHelper.GetParent(myButton4);
            grid1.Children.Remove(myButton4);
        }
        private void myButton_MouseRightButtonDown5(object sender, MouseButtonEventArgs e)
        {
            Grid grid1 = (Grid)VisualTreeHelper.GetParent(myButton5);
            grid1.Children.Remove(myButton5);
        }
        private void myButton_MouseRightButtonDown6(object sender, MouseButtonEventArgs e)
        {
            Grid grid1 = (Grid)VisualTreeHelper.GetParent(myButton6);
            grid1.Children.Remove(myButton6);
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            byte[] color = new byte[3];
            rnd.NextBytes(color);

            Color randomcolor = Color.FromArgb(255, color[0], color[1], color[2]);
            SolidColorBrush brush = new SolidColorBrush(randomcolor);
            myButton3.Background = brush;
            MessageBox.Show(randomcolor.ToString(), "BU RENG", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            byte[] color = new byte[3];
            rnd.NextBytes(color);

            Color randomcolor = Color.FromArgb(255, color[0], color[1], color[2]);
            SolidColorBrush brush = new SolidColorBrush(randomcolor);
            myButton4.Background = brush;
            MessageBox.Show(randomcolor.ToString(), "BU RENG", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            byte[] color = new byte[3];
            rnd.NextBytes(color);

            Color randomcolor = Color.FromArgb(255, color[0], color[1], color[2]);
            SolidColorBrush brush = new SolidColorBrush(randomcolor);
            myButton5.Background = brush;
            MessageBox.Show(randomcolor.ToString(), "BU RENG", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            byte[] color = new byte[3];
            rnd.NextBytes(color);

            Color randomcolor = Color.FromArgb(255, color[0], color[1], color[2]);
            SolidColorBrush brush = new SolidColorBrush(randomcolor);
            myButton6.Background = brush;
            MessageBox.Show(randomcolor.ToString(), "BU RENG", MessageBoxButton.OK, MessageBoxImage.Error);
        }


    }
}
