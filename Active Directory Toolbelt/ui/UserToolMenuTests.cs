using Active_Directory_Toolbelt.ui;
using FakeItEasy;
using System;
using Xunit;

namespace Active_Directory_Toolbelt.ui
{
    public class UserToolMenuTests
    {


        public UserToolMenuTests()
        {

        }

        private UserToolMenu CreateUserToolMenu()
        {
            return new UserToolMenu();
        }

        [Fact]
        public void TestMethod1()
        {
            // Arrange
            var userToolMenu = this.CreateUserToolMenu();

            // Act


            // Assert
            Assert.True(false);
        }
    }
}
