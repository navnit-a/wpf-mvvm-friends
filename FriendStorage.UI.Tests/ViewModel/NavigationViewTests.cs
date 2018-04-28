using System.Linq;
using FriendStorage.UI.Tests.Mocks;
using FriendStorage.UI.ViewModel;
using Xunit;

namespace FriendStorage.UI.Tests.ViewModel
{
    public class NavigationViewTests
    {
        [Fact]
        public void ShouldLoadFriends()
        {
            // Arrange
            var navigationViewModel = new NavigationViewModel(new NavigationDataProviderMock());

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
            var navigationViewModel = new NavigationViewModel(new NavigationDataProviderMock());

            // Act
            navigationViewModel.Load();
            navigationViewModel.Load();

            // Assert
            Assert.Equal(2, navigationViewModel.Friends.Count);
        }
    }
}