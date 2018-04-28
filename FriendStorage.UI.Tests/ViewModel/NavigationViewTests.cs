using System.Collections.Generic;
using System.Linq;
using FriendStorage.Model;
using FriendStorage.UI.DataProvider;
using FriendStorage.UI.ViewModel;
using Moq;
using Xunit;

namespace FriendStorage.UI.Tests.ViewModel
{
    public class NavigationViewTests
    {
        private readonly Mock<INavigationDataProvider> _navigationDataProviderMock;

        public NavigationViewTests()
        {
            _navigationDataProviderMock = new Mock<INavigationDataProvider>();
            _navigationDataProviderMock.Setup(x => x.GetAllFriends()).Returns(new List<FriendLookupItem>
            {
                new FriendLookupItem  { DisplayMember = "nAvz killa", Id = 1},
                new FriendLookupItem { DisplayMember = "Neelam Paree", Id = 2}
            });
        }

        [Fact]
        public void ShouldLoadFriends()
        {
            // Arrange
             
            
            var navigationViewModel = new NavigationViewModel(_navigationDataProviderMock.Object);

            // Act
            navigationViewModel.Load();

            // Assert
            Assert.Equal(2, navigationViewModel.Friends.Count);

            var friend = navigationViewModel.Friends.SingleOrDefault(f => f.Id == 1);
            Assert.NotNull(friend);
            Assert.Equal("nAvz killa", friend.DisplayMember);
        }

        [Fact]
        public void ShouldLoadTestsOnlyOnce()
        {
            // Arrange
            var navigationViewModel = new NavigationViewModel(_navigationDataProviderMock.Object);

            // Act
            navigationViewModel.Load();
            navigationViewModel.Load();

            // Assert
            Assert.Equal(2, navigationViewModel.Friends.Count);
        }
    }
}