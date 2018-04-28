using FriendStorage.UI.Contracts;
using FriendStorage.UI.ViewModel;
using Moq;
using Xunit;

namespace FriendStorage.UI.Tests.ViewModel
{
    public class MainViewModelTests
    {
        [Fact]
        public void ShouldCallTheLoadMethodOfTheNavigationViewModel()
        {
            var navigationViewModelMock = new Mock<INavigationViewModel>();

            //// Arrange
            var mainViewModel = new MainViewModel(navigationViewModelMock.Object);

            //// Act
            mainViewModel.Load();

            //// Assert
            navigationViewModelMock.Verify(x => x.Load(), Times.Once);
        }
    }
}