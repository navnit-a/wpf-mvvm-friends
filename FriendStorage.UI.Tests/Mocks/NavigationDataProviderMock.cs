using System.Collections.Generic;
using FriendStorage.Model;
using FriendStorage.UI.DataProvider;

namespace FriendStorage.UI.Tests.Mocks
{
    public class NavigationDataProviderMock : INavigationDataProvider
    {
        public IEnumerable<Friend> GetAllFriends()
        {
            yield return new Friend {FirstName = "nAvz", LastName = "kIlla", IsDeveloper = true, Id = 1};
            yield return new Friend {FirstName = "Harvey", LastName = "Nash", IsDeveloper = true, Id = 2};
        }
    }
}