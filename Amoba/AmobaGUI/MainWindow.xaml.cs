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
using System.Xml.Linq;
using System.IO;

namespace AmobaGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int[,] values;
        public MainWindow()
        {
            InitializeComponent();
            Player1.Text = "Józsi";
            Player2.Text = "Karesz";
            TBoxName.Text = "minta.txt";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            values = new int[4, 4];

            GameField.Children.Clear();
            for (int rowIndex = 0; rowIndex < 4; rowIndex++)
            {
                for (int colIndex = 0; colIndex < 4; colIndex++)
                {
                    var gfield = new Button() { Margin = new Thickness(5) };
                    gfield.FontSize = 16;
                    gfield.FontWeight = FontWeights.Bold;
                    GameField.Children.Add(gfield);
                    Grid.SetColumn(gfield, colIndex);
                    Grid.SetRow(gfield, rowIndex);
                }
            }
        }
        private void Save(object sender, RoutedEventArgs e)
        {
            StringBuilder sbd = new StringBuilder();
            for (int rowIndex = 0; rowIndex < 4; rowIndex++)
            {
                sbd.Append(values[rowIndex, 0].ToString());
                for (int colIndex = 1; colIndex < 5; colIndex++)
                {
                    sbd.Append(';');

                }
                sbd.AppendLine();
            }
            File.WriteAllText(TBoxName.Text, sbd.ToString());
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var gridLength = new GridLength(30);
            for (int i = 0; i < 4; i++)
            {
                GameField.RowDefinitions.Add(new RowDefinition() { Height = gridLength });
                GameField.ColumnDefinitions.Add(new ColumnDefinition() { Width = gridLength });
            }
        }
    }
}
