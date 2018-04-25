namespace FriendStorage.UI.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public NavigationViewModel NavigationViewModel { get; private set; }

        public MainViewModel()
        {
            NavigationViewModel = new NavigationViewModel();
        }

        public void Load()
        {
            NavigationViewModel.Load();
        }
    }
}