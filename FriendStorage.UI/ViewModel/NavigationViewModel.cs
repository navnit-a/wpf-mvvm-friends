using System.Collections.ObjectModel;
using FriendStorage.DataAccess;
using FriendStorage.Model;

namespace FriendStorage.UI.ViewModel
{
    public class NavigationViewModel : ViewModelBase
    {
        public NavigationViewModel()
        {
            Friends = new ObservableCollection<Friend>();
        }

        public ObservableCollection<Friend> Friends { get; }

        public void Load()
        {
            var dataService = new FileDataService();
            var allFriends = dataService.GetAllFriends();
            foreach (var friend in allFriends)
                Friends.Add(friend);
        }
    }
}