using Active_Directory_Toolbelt.ui;
using FakeItEasy;
using System;
using Xunit;

namespace Active_Directory_Toolbelt.ui
{
    public class AdminToolsTests
    {


        public AdminToolsTests()
        {

        }

        private AdminTools CreateAdminTools()
        {
            return new AdminTools();
        }

        [Fact]
        public void TestMethod1()
        {
            // Arrange
            var adminTools = this.CreateAdminTools();

            // Act


            // Assert
            Assert.True(false);
        }
    }
}
