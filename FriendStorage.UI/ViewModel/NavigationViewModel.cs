using System.Collections.ObjectModel;
using FriendStorage.DataAccess;
using FriendStorage.Model;
using FriendStorage.UI.DataProvider;

namespace FriendStorage.UI.ViewModel
{
    public class NavigationViewModel : ViewModelBase
    {
        private readonly INavigationDataProvider _navigationDataProvider;

        public NavigationViewModel(INavigationDataProvider navigationDataProvider)
        {
            _navigationDataProvider = navigationDataProvider;
            Friends = new ObservableCollection<Friend>();
        }

        public ObservableCollection<Friend> Friends { get; }

        public void Load()
        {
            //var dataService = new FileDataService(); 
            //var allFriends = dataService.GetAllFriends();
            Friends.Clear();
            var allFriends = _navigationDataProvider.GetAllFriends();

            foreach (var friend in allFriends)
            {
                Friends.Add(friend);
            }
        }
    }
}