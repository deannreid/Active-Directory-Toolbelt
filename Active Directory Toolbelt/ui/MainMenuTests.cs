using Active_Directory_Toolbelt.ui;
using FakeItEasy;
using System;
using Xunit;

namespace Active_Directory_Toolbelt.ui
{
    public class MainMenuTests
    {


        public MainMenuTests()
        {

        }

        private MainMenu CreateMainMenu()
        {
            return new MainMenu();
        }

        [Fact]
        public void StartProgramUIMethod()
        {
            // Arrange
            var mainMenu = this.CreateMainMenu();

            // Act


            // Assert
            Assert.True(false);
        }
    }
}
