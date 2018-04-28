using System.Collections.ObjectModel;
using FriendStorage.Model;
using FriendStorage.UI.Contracts;
using FriendStorage.UI.DataProvider;

namespace FriendStorage.UI.ViewModel
{
    public class NavigationViewModel : ViewModelBase, INavigationViewModel
    {
        private readonly INavigationDataProvider _navigationDataProvider;

        public NavigationViewModel(INavigationDataProvider navigationDataProvider)
        {
            _navigationDataProvider = navigationDataProvider;
            Friends = new ObservableCollection<FriendLookupItem>();
        }

        public ObservableCollection<FriendLookupItem> Friends { get; }

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