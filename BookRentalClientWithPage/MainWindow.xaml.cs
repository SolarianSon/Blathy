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

namespace BookRentalClientWithPage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mainPage = new MainPage();
        }
        private MainPage mainPage;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = mainPage;
            mainPage.BTN_NewBook.Click += BTN_NewBook_Click;
            mainPage.BTN_DeleteBook.Click += BTN_DeleteBook_Click;
            mainPage.BTN_EditBook.Click += BTN_EditBook_Click;
        }

        private void BTN_EditBook_Click(object sender, RoutedEventArgs e)
        {
            var page = new BookEditorPage();
            MainFrame.Content = page;
            page.BTN_Cancel.Click += BookEditorPage_BTN_Cancel_Click;
        }
        private void BTN_DeleteBook_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
        private void BTN_NewBook_Click(object sender, RoutedEventArgs e)
        {
            var page = new BookEditorPage();
            MainFrame.Content = page;
            page.BTN_Cancel.Click += BookEditorPage_BTN_Cancel_Click;
        }
        private void BookEditorPage_BTN_Cancel_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = mainPage;
        }
    }
}