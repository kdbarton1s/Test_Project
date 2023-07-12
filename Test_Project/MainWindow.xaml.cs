
using System.Windows;


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
