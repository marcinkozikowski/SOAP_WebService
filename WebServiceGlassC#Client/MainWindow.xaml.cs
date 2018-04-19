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

namespace WebServiceClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HelloWorldImplService hw;
        public MainWindow()
        {
            InitializeComponent();
            hw = new HelloWorldImplService();
        }

        private void nameBTN_Click(object sender, RoutedEventArgs e)
        {
            string response = hw.getHelloWorldAsString(nameTextBox.Text);
            nameLabel.Content = response;
        }

        private void productBTN_Click(object sender, RoutedEventArgs e)
        {
            product[] list = hw.getProducts();
            for(int i=0;i<list.Length;i++)
            {
                productsLabel.Content = productsLabel.Content + list[i].nazwa + " " + list[i].opis + " " + list[i].cena + "\n";
            }
        }
    }
}
