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
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Test_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            this.Resources["Word"] = "Enter";
            this.Resources["Message"] = "Hit the enter key";
            
        }

        public void ButtonClick(object sender, RoutedEventArgs e)
        {
            if (Resources["Word"] == "Enter")
            {
                Resources["Message"] = "ImagineSoftware is a leading provider of medical billing, revnue cycle, and practice management software";
                Resources["Word"] = "Exit";
            } else
            {
                Resources["Message"] = "Hit the Enter key";
                Resources["Word"] = "Enter";
            }
        }
    }
}
