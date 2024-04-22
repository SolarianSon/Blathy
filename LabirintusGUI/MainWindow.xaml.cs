using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LabirintusGUI
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

        private void Button_Click(object sender , RoutedEventArgs e)
        {
            int rows = 12;
            int cols = 12;

            for (int row = 0; row < Height; row++)
            {
                for (int col = 0; col < Width; col++)
                {
                    CheckBox box = new CheckBox();
                    if (row == 0)
                    {
                        box.IsChecked = true;
                    }
                    if (row == Height - 1)
                    {
                        box.IsChecked = true;
                    }
                    Lab.Children.Add(box);
                }
            }
        }
    }
}