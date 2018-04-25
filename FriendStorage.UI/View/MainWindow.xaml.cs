using System.Windows;
using FriendStorage.UI.ViewModel;

namespace FriendStorage.UI.View
{
    public partial class MainWindow : Window
    {
        private readonly MainViewModel _mainViewModel;

        public MainWindow(MainViewModel mainViewModel)
        {
            InitializeComponent();

            //Event handler
            Loaded += MainWindow_Loaded;

            _mainViewModel = mainViewModel;
            DataContext = _mainViewModel;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            _mainViewModel.Load();
        }
    }
}