//Aidan McClung
//March 22, 2018
//u2Snowman
//Draws a Snowman

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

namespace u2Snowman
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Ellipse Head = new Ellipse();
            Ellipse Mid = new Ellipse();
            Ellipse Bot = new Ellipse();

            int a = 100;
            int b = 50;
            //step 1 x values
            //step 2 y values

            for (int i = 0; i < 3; i++)
            {

                int Width = a * i + b;

                int Height = a * i + b;

                myStackpanel.Children.Add(drawellipse(Width, Height));
            }

            Ellipse drawellipse(double x1, double y1)
            {
                Ellipse myEllipse = new Ellipse();
                myEllipse.Width = x1;
                myEllipse.Height = y1;
                myEllipse.Stroke = Brushes.Black;
                myEllipse.HorizontalAlignment = HorizontalAlignment.Center;
                return myEllipse;
            }
        }
    }
}
