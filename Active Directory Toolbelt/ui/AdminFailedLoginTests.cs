using Active_Directory_Toolbelt.ui;
using FakeItEasy;
using System;
using Xunit;

namespace Active_Directory_Toolbelt.ui
{
    public class AdminFailedLoginTests
    {


        public AdminFailedLoginTests()
        {

        }

        private AdminFailedLogin CreateAdminFailedLogin()
        {
            return new AdminFailedLogin();
        }

        [Fact]
        public void TestMethod1()
        {
            // Arrange
            var adminFailedLogin = this.CreateAdminFailedLogin();

            // Act


            // Assert
            Assert.True(false);
        }
    }
}
