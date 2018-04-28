using System.Collections.Generic;
using FriendStorage.Model;
using FriendStorage.UI.DataProvider;

namespace FriendStorage.UI.Tests.Mocks
{
    public class NavigationDataProviderMock : INavigationDataProvider
    {
        public IEnumerable<FriendLookupItem> GetAllFriends()
        {
            yield return new FriendLookupItem  { DisplayMember = "nAvz killa", Id = 1};
            yield return new FriendLookupItem { DisplayMember = "Neelam Paree", Id = 2};
        }
    }
}