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

namespace Cliker
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        long point = 250;
        static int click = 10;
        double sol_b1 = 10 + 10 * (30 + click * 0.2);
        double sol_b2 = 20 + 20 * (60 + click * 0.4);
        double sol_b3 = 40 + 40 * (120 + click * 0.8);
        double sol_b4 = 80 + 80 * (240 + click * 1.2);


        public MainWindow()
        {
            InitializeComponent();
            Update();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            point += click;
            Update();
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            ClickClass.ClickMethod(100, sol_b1, ref point, ref click);
            Update();
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            ClickClass.ClickMethod(250, sol_b2, ref point, ref click);
            Update();
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            ClickClass.ClickMethod(500, sol_b3, ref point, ref click);
            Update();
        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            ClickClass.ClickMethod(1000, sol_b4, ref point, ref click);
            Update();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        public void Update()
        {
            allPoint.Content = "Points: " + point; 
            onClick.Content = "Points for click: " + click; 
            b1.Content = (sol_b1).ToString(); 
            b2.Content = (sol_b2).ToString(); 
            b3.Content = (sol_b3).ToString(); 
            b4.Content = (sol_b4).ToString(); 
        }
    }
}
