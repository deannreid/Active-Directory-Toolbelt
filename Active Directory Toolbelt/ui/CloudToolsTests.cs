using Active_Directory_Toolbelt.ui;
using FakeItEasy;
using System;
using Xunit;

namespace Active_Directory_Toolbelt.ui
{
    public class CloudToolsTests
    {


        public CloudToolsTests()
        {

        }

        private CloudTools CreateCloudTools()
        {
            return new CloudTools();
        }

        [Fact]
        public void TestMethod1()
        {
            // Arrange
            var cloudTools = this.CreateCloudTools();

            // Act


            // Assert
            Assert.True(false);
        }
    }
}
