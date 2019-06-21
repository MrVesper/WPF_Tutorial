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

namespace WPF_Tutorial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Title = "This is Main Window of the WPF application";
        }

        private void Applay_BTN_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Description is: {this.DescriptionTextBox.Text}");
        }

        private void Reset_BTN_Click(object sender, RoutedEventArgs e)
        {
            for(int i = 0; i<Column1.Children.Count && i< Column2.Children.Count; i++)
            {
                var element = Column1.Children[i] as CheckBox;
                element.IsChecked = false;

                var element2 = Column2.Children[i] as CheckBox;
                element2.IsChecked = false;
            }
        }
    }
}
